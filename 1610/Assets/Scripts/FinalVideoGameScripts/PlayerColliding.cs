using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerColliding : MonoBehaviour
{

    public CharacterMover Mover;
    
    //public Vector3 velocity;

    private void OnCollisionEnter(Collision col)
    {
        Debug.Log(gameObject.name + "has collided with" + col.gameObject.name);
        Mover.enabled = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(gameObject.name + "was triggered by" + other.gameObject.name);
    }
}

