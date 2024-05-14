using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    public bool playerDetection = false;
    
    void Update()
    {
        if (playerDetection && Input.GetKeyDown(KeyCode.F))
        {
            print("Dialog Starter");        
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Player")
        {
            playerDetection = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.name == "Player")
        {
            playerDetection = false;
        }
    }

    // Update is called once per frame
}
