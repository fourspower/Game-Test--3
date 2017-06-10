using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggert : MonoBehaviour
{
    public List<Collider> triggers;

    void OnTriggerEnter(Collider other)
    {
        triggers.Add(other);
    }

    void OnTriggerExit(Collider other)
    {
        triggers.Remove(other);
    }
}
