using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Verbricken : MonoBehaviour {

    public MainManager mainmanagerverbrick;
    public GameObject Manager;

    public float einnahmen;
    public int ausgebaut;
    public GameObject Rauch;

    public float leute;
    public float needworker;
    public float arbeiter;

    public float arbeitszeit;
    public float arbeitszeitrs;


    public bool onwork = false;

    void Start ()
    {
        arbeitszeitrs = 10;
        arbeitszeit = arbeitszeitrs;
        ausgebaut = 1;
        needworker += mainmanagerverbrick.NeedWorker;
    }


    void Update()
    {
        Manager = GameObject.FindGameObjectWithTag("Manager");
        mainmanagerverbrick = Manager.GetComponent<MainManager>();


        //Wenn arbeit an is
        if(onwork == true)
        {
            //zeitablaufen
            arbeitszeit -= Time.deltaTime;
            Rauch.SetActive(true);
        }
        else
        {
            Rauch.SetActive(false);
            if (needworker <= mainmanagerverbrick.people)
            {
                //dann soll leute -= benötigte leute sein
                mainmanagerverbrick.people -= needworker;
                arbeiter += needworker;
                mainmanagerverbrick.peoplework += needworker;
                arbeiter += mainmanagerverbrick.peoplework;
            }
        }

        if(needworker == arbeiter)
        {
            onwork = true;
        }
        else
        {
            onwork = false;
        }

        if (ausgebaut == 1)
        {
            needworker = 4;
            // wenn arbeiter <= gevrauchte arbeiter is und zeit =0 is dann geld und time rs
            if(arbeiter <= needworker && arbeitszeit <= 0)
            {
                arbeitszeit = arbeitszeitrs;
                einnahmen = 10;
                mainmanagerverbrick.Money += einnahmen;
            }
        }

        if (ausgebaut == 2)
        {
            needworker = 6;
            if (arbeiter <= 2 && arbeitszeit <= 0)
            {
                arbeitszeit = arbeitszeitrs;
                einnahmen = 25;
                mainmanagerverbrick.Money += einnahmen;
                Rauch.SetActive(true);
            }
        }
    }

    public void workseter()
    {
        mainmanagerverbrick.people -= needworker;
        arbeiter += mainmanagerverbrick.peoplework;
        needworker = 0;
        onwork = true;
    }

    public void OnMouseDown()
    {
        gameObject.tag = "FabrikUpgrade";

        mainmanagerverbrick.GetComponent<UIManager>().OpenFabrikUpgradeMenu();
    }
}
