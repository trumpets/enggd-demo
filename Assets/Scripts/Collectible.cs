using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    public void OnTriggerEnter(Collider other) 
    {   
        if (other.CompareTag("Player")) 
        {
            // Destroy the collectible
            Destroy(gameObject);
        }
       
    }
}
