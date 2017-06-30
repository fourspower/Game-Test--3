using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Huamns : MonoBehaviour {

    public Transform Haus;
    public Transform Arbeit;
    public NavMeshAgent NavComponent;
    public bool ZuHause = false;
    public bool AufArbeit = false;

    void Start ()
    {
       NavComponent = this.transform.GetComponent<NavMeshAgent>();

    }
	
	// Update is called once per frame
	void Update ()
    {
        if (ZuHause == true)
        {
            NavComponent.SetDestination(Haus.position);
            AufArbeit = false;
        }

        if (AufArbeit == true)
        {
            NavComponent.SetDestination(Arbeit.position);
            ZuHause = false;
        }
    }

    private void OnTriggerEnter(Collider haus)
    {
        if(haus.gameObject.tag == "Haus")
        {
            Haus = haus.transform;
        }
    }
}
