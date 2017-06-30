using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMainObjSpawner : MonoBehaviour {

    public GameObject MainSpawner;
    public float PlayerX;
    public float PlayerZ;
    public Vector3 center;
    public Vector3 große;

	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (gameObject.tag == "Spawner1")
        {
            Instantiate(MainSpawner, center, gameObject.transform.rotation);

        }

        if (gameObject.tag == "Spawner2")
        {

        }

        if(Input.GetKeyDown(KeyCode.K))
        {
            SpawnMainSpaner();
        }
    }

    public void SpawnMainSpaner()
    {
        gameObject.transform.position = center;
        PlayerX = Random.Range(-1000, 1000);
        PlayerZ = Random.Range(-1000, 1000);
        center = new Vector3(PlayerX, 0, PlayerZ);
        Instantiate(MainSpawner, center, gameObject.transform.rotation);
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = new Color(1, 0, 0, 0.5f);
        Gizmos.DrawCube(transform.localPosition + center, große);
    }
}
