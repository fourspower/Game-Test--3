using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Verbricken : MonoBehaviour {

    public MainManager mainmanagerverbrick;
    public GameObject Manager;

    public float einnahmen;
    public int ausgebaut;

    public float leute;
    public float needworker;
    public float arbeiter;

    public float arbeitszeit;
    public float arbeitszeitrs;


    public bool onwork = false;

    void Start ()
    {
        arbeitszeitrs = 5;
        arbeitszeit = arbeitszeitrs;
        ausgebaut = 1;
        needworker = 2;
    }


    void Update()
    {
        Manager = GameObject.FindGameObjectWithTag("Manager");
        mainmanagerverbrick = Manager.GetComponent<MainManager>();

        if (needworker >= 0)
        {
            if (mainmanagerverbrick.people >= needworker && onwork == false)
            {
                mainmanagerverbrick.people -= needworker;
                arbeiter += needworker;
                needworker = -1;
                onwork = true;
            }
        }

        if(onwork == true)
        {
            arbeitszeit -= Time.deltaTime;
        }

        if(ausgebaut == 1)
        {
            needworker = 2;
            if(onwork == true && arbeitszeit <= 0)
            {
                arbeitszeit = arbeitszeitrs;
                einnahmen = 10;
                mainmanagerverbrick.Money += einnahmen;
            }
        }



    }
}
