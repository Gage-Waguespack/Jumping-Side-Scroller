using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementBehaviour : MonoBehaviour
{
    public float HorizontalSpeed = 2;
    public float StartCos = 0;

    
    void Start()
    {

    }

    void Update()
    {
        //moves their transform on the x axis based on horizontal speed.
        transform.position -= new Vector3(HorizontalSpeed, 0, 0) * Time.deltaTime;
        StartCos += Time.deltaTime;
    }
}
