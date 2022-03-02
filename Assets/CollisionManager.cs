using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionManager : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D coll)
    {
        if(coll.CompareTag("Fuego"))
        {
            Debug.Log("Player has entered the trigger");
        }
    }
}
