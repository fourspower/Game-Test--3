using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkSpawnPos : MonoBehaviour {

    public GameObject SpawnerSpwaner;

    public SpawnBase spawnbase;

    private void FixedUpdate()
    {
        if (gameObject.tag == "Player1")
        {
            SpawnerSpwaner = GameObject.FindGameObjectWithTag("Spawner1");
        }

        if (gameObject.tag == "Player2")
        {
            SpawnerSpwaner = GameObject.FindGameObjectWithTag("Spawner2");
        }
    }

    void OnTriggerStay(Collider Baswalls)
    {
        if (Baswalls.gameObject.tag == "Walls")
        {
            
            if (SpawnerSpwaner.tag == "Spawner2")
            {
                Debug.Log("kevin2");
                Destroy(gameObject);
            }

            if (SpawnerSpwaner.tag == "Spawner1")
            {
                Debug.Log("kevin1");
                Destroy(gameObject);
            }
            
        }
    }

    public void newspawner()
    {
        
    }
}
