using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreTracker : MonoBehaviour
{
    [SerializeField]
    private Text _score;

    public void setScore(int Score)
    {
        _score.text = Score.ToString();
    }
}
