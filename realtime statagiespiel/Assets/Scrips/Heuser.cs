using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heuser : MonoBehaviour {

    public MainManager mainmanagerheuser;
    public float einfohner;
    public int hausstufe;
    public bool gebaut;
    public GameObject Manager;

    void Start ()
    {
        Manager = GameObject.FindGameObjectWithTag("Manager");
        hausstufe = 1;
	}
	
	// Update is called once per frame
	void Update ()
    {
        mainmanagerheuser = Manager.GetComponent<MainManager>();

        if (gebaut == true)
        {
            gebaut = false;
            if (hausstufe == 1)
            {
                einfohner = 2;
                mainmanagerheuser.people += einfohner;
            }
        }
	}
}
