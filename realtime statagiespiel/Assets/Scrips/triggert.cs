using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggert : MonoBehaviour
{
    public List<Collider> triggers;
    public GameObject triggerboxgreen;
    public GameObject trigerboxred;

    private void Start()
    {
        triggerboxgreen.SetActive(true);
    }

    private void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        triggers.Add(other);
        trigerboxred.SetActive(true);
        triggerboxgreen.SetActive(false);
    }

    void OnTriggerExit(Collider other)
    {
        triggers.Remove(other);
        trigerboxred.SetActive(false);
        triggerboxgreen.SetActive(true);
    }
}
