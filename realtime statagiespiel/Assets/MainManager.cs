using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainManager : MonoBehaviour {

    public float people;
    public float peoplework;
    public float Money;


    void Start ()
    {
		
	}


	void Update ()
    {
		
	}

    void OnGUI()
    {
        GUI.Label(new Rect(900, 10, 100, 20), "Money: "+ Money);
        GUI.Label(new Rect(900, 30, 100, 20), "People: " + people);
    }
}
