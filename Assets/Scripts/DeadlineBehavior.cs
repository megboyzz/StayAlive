using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadlineBehavior : MonoBehaviour {

    public GameObject deadline;

    public GameObject motobike;
    
    private void Start()
    {
        
    }

    private void Update()
    {
        Instantiate(deadline, motobike.transform.position, Quaternion.identity);
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Меня тронули! " + other.tag);
    }
}
