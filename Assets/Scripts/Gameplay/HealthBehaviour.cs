using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBehaviour : MonoBehaviour
{
    //Serialized variable that contains the health value
    [SerializeField]
    private float _health;

    //Serialized variable that destroys the player
    [SerializeField]
    private bool _destroyOnDeath = true;

    //A variable that takes in the players current health
    public float Health
    {
        get
        {
            return _health;
        }
    }

    /// <summary>
    /// Subtracts the given damage value from the health
    /// </summary>
    /// <param name="damage"></param>
    public void TakeDamage(float damage)
    {
        _health -= damage;

        if (_health < 0)
            _health = 0; 
    }

    void Update()
    {
        //If the object health is lower or equal to 0, destroy the object
        if (_health <= 0 && _destroyOnDeath)
            Destroy(gameObject);
        //Else, don't destroy object, deactivate it instead
        else if (_health <= 0)
            gameObject.SetActive(false);
    }
}
