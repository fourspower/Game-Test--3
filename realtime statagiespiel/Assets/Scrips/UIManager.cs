using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour {

    public GameObject BulindMenu;
    public GameObject Pannel;
    public GameObject FabrikUpgradeMenu;
    public bool pannelonoff;


    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OpenBulindMenu()
    {
        BulindMenu.SetActive(true);
    }

    public void CloseBulindMenu()
    {
        BulindMenu.SetActive(false);
    }

    public void OpenPannelMenu()
    {
        if (pannelonoff == false)
        {
            Pannel.SetActive(true);
            pannelonoff = true;
        }
        else
        {
            Pannel.SetActive(false);
            pannelonoff = false;
        }
    }

    public void OpenFabrikUpgradeMenu()
    {

        FabrikUpgradeMenu.SetActive(true);
    }

}
