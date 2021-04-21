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
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
           _playerHealth.TakeDamage(1);
    }

    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_playerRef.transform.position.y <= 3)
        {
            if (Input.GetMouseButtonDown(0))
            {
                _rigidbody.AddForce(new Vector3(0, JumpForce, 0), ForceMode.Impulse);
            }
        }
    }
}
