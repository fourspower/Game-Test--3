using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBase : MonoBehaviour {

    public GameObject SpawnPrefab;

    public Vector3 spawnBalues;

    public string player;
    public string TagName;
    public string PlayerTag;

    public bool stop;


	void Start ()
    {
        SpawnSpawner();
        TagName = gameObject.tag;
    }
	
	// Update is called once per frame
	void Update()
    {
        if(Input.GetKeyDown(KeyCode.K))
        {
            SpawnSpawner();
        }
    }

    public void SpawnSpawner()
    {
        Vector3 spawnPotiotion = gameObject.transform.position + new Vector3(Random.Range(-spawnBalues.x / 2, spawnBalues.x / 2), 1, Random.Range(-spawnBalues.z / 2, spawnBalues.z / 2));

        Instantiate(SpawnPrefab, spawnPotiotion, Quaternion.identity);

        SpawnPrefab.name = player;
        SpawnPrefab.tag = PlayerTag;
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = new Color(1, 0, 0, 0.5f);
        Gizmos.DrawCube(gameObject.transform.localPosition, spawnBalues);
    }
}
