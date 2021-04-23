using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreBoxBehaviour : MonoBehaviour
{
    //Variable to get a refference to the ScoreTracker
    public ScoreTracker ScoreTracker;

    //This is the Score
    public int Score;

    //Every time the player collides with the ScoreTracker, the score goes up
    private void OnTriggerEnter(Collider collision)
    {
        Debug.Log("OnTriggerEnter");
        if (collision.gameObject.CompareTag("Player"))
        {
            //IncrementScore is called when the player collides with the ScoreBox
            GameManagerBehaviour.Instance.IncrementScore();
        }
    }

    //returns the score
    public int getScore()
    {
        return Score;
    }
}
