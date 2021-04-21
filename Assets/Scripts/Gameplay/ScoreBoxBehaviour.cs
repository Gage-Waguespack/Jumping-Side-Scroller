using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreBoxBehaviour : MonoBehaviour
{
    public ScoreTracker ScoreTracker;

    public int Score;

    private void OnTriggerEnter(Collider collision)
    {
        Debug.Log("OnTriggerEnter");
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("CompareTag");
            GameManagerBehaviour.Instance.IncrementScore();
        }
    }

    public int getScore()
    {
        return Score;
    }
}
