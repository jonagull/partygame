using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballThrow : MonoBehaviour
{
    public GameObject fireballPrefab;
    public Transform firePoint;

    // private void Start()
    // {
    //     fireballPrefab = GameObject.Find("fireballPrefab");
    // }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            ThrowFireball();
        }
    }

    // ReSharper disable Unity.PerformanceAnalysis
    void ThrowFireball()
    {
        GameObject player = GameObject.FindWithTag("Player");

        if (player != null)
        {
            // Get the position of the player
            Vector3 playerPosition = player.transform.position;

            // Instantiate a new fireball at the player's position
            GameObject fireball = Instantiate(fireballPrefab, playerPosition, Quaternion.identity);
        
            // Set the fireball's velocity if you want it to inherit the character's velocity
            Rigidbody rb = fireball.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.velocity = transform.forward * fireball.GetComponent<Fireball>().speed;
            }
        }
        else
        {
            Debug.LogWarning("Player object not found.");
        }
    }

}