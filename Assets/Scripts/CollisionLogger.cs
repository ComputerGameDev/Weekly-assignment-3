using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionLogger : MonoBehaviour
{
    private void Start()
    {
        Debug.Log("Start Collision Logger on: " + this.name);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other != null)
        {
            Debug.Log($"{this.name} Trigger with {other.name}, tag={other.tag}");
        }
        else
        {
            Debug.LogError("Collision detected, but 'other' is null!");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
