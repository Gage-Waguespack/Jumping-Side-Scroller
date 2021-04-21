using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathWallBehaviour : MonoBehaviour
{
    public void Destroy()
    {
        Destroy(gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Obstacle"))
            Destroy(other.gameObject);
    }
}
