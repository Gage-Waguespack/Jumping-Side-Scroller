using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathWallBehaviour : MonoBehaviour
{
    //overloads destroy to destroy any game object it collides with
    public void Destroy()
    {
        Destroy(gameObject);
    }

    //Once triggered, it destroys the gameObject if it is tagged "Obstacle"
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Obstacle"))
            Destroy(other.gameObject);
    }
}
