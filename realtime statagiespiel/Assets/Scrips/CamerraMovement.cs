using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamerraMovement : MonoBehaviour {

    public float moveback = 1f;
    public float moveback1 = 1f;
    public float movefor = 1f;
    public float movefor1 = 1f;
    public float rot1 = 0.5f;
    public float rot2 = -0.5f;

    public float movespeed;

    public Transform Maincamobjc;
    public Transform RotCamObjc;

    public bool toheight;
    public bool tolow;

    void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if(Input.GetKeyDown(KeyCode.LeftShift))
        {
            movespeed += 100;
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            movespeed -= 100;
        }

        if (tolow == false)
        {
            if (Input.GetAxis("Mouse ScrollWheel") > 0)
            {
                GetComponent<Transform>().position = new Vector3(transform.position.x, transform.position.y - moveback, transform.position.z + moveback1);
                RotCamObjc.transform.Rotate(rot1, 0, 0);
                movespeed -= 1;
            }
        }

        if (toheight == false)
        {
            if (Input.GetAxis("Mouse ScrollWheel") < 0)
            {
                GetComponent<Transform>().position = new Vector3(transform.position.x, transform.position.y + movefor, transform.position.z - movefor1);
                RotCamObjc.transform.Rotate(rot2, 0, 0);
                movespeed += 1;
            }
        }

        if (RotCamObjc.rotation.eulerAngles.x <= 40)
        {
            tolow = true;
        }
        else
        {
            tolow = false;
        }

        if (RotCamObjc.rotation.eulerAngles.x >= 90)
        {
            toheight = true;
        }
        else
        {
            toheight = false;
        }

        transform.Translate(movespeed * Input.GetAxis("Horizontal") * Time.deltaTime, 0f, movespeed * Input.GetAxis("Vertical") * Time.deltaTime);
    }
}
