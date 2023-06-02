using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadlineTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private TrailRenderer s;
    
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Меня тронули " + other.name);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
