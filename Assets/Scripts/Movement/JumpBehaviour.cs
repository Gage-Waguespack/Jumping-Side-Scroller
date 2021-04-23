using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;

public class JumpBehaviour : MonoBehaviour
{
    private Rigidbody _rigidbody;
    public float JumpForce = 5;
    [SerializeField]
    private GameObject _playerRef;
    [SerializeField]
    private HealthBehaviour _playerHealth;

    //Checks if the object that collides with the object is tagged obstacle
    //If so, takeDamage
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
           _playerHealth.TakeDamage(1);
    }

    void Start()
    {
        //Checks rigidBody on start
        _rigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        //On update, checks if you press LMouse, if so, apply force on the y axis
        if (_playerRef.transform.position.y <= 3)
        {
            if (Input.GetMouseButtonDown(0))
            {
                _rigidbody.AddForce(new Vector3(0, JumpForce, 0), ForceMode.Impulse);
            }
        }
    }
}
