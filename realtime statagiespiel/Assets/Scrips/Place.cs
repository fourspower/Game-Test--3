using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Place : MonoBehaviour {

    public LayerMask sufaceLayer;
    public MoneyManager moneymanager;
    public Deplace DestoryCurObj;
    public MainManager mainmanager;
    public Heuser bildings;
    public GameObject tiggerboxen;

    public GameObject Manager;
    private Transform currentBuilding;
    private Camera myCamerra;

    public bool placed;

	void Start ()
    {
        myCamerra = GetComponent<Camera>();
    }



    void Update()
    {
        if (currentBuilding != null)
        {
            bildings = currentBuilding.GetComponent<Heuser>();
            DestoryCurObj = currentBuilding.GetComponent<Deplace>();
            moneymanager = currentBuilding.GetComponent<MoneyManager>();
            mainmanager = Manager.GetComponent<MainManager>();

            Ray ray = myCamerra.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, Mathf.Infinity, sufaceLayer))
            {
                currentBuilding.position = hit.point;
            }

            if (Input.GetMouseButtonDown(0))
            {
                if (mainmanager.Money >= moneymanager.kosten)
                {
                    if (currentBuilding.GetComponent<triggert>().triggers.Count == 0)
                    {
                        if (currentBuilding.tag == "Haus")
                        {
                            currentBuilding = null;
                            mainmanager.Money -= moneymanager.kosten;
                            bildings.gebaut = true;
                        }

                        if (currentBuilding.tag == "Fabrik")
                        {
                            currentBuilding = null;
                            mainmanager.Money -= moneymanager.kosten;
                        }
                    }
                }
                else
                {
                    Debug.Log("nicht genung geld");
                }
            }
            else if (Input.GetMouseButtonDown(1))
            {
                Destroy(currentBuilding.gameObject);
            }
        }
    }
    


public void SetCurrentBuilding(GameObject building)
    {
        currentBuilding = ((GameObject)Instantiate(building)).transform;
    }
}
