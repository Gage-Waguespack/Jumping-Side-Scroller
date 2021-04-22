using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreTracker : MonoBehaviour
{
    [SerializeField]
    private Text _score;

    //sets the score by turning the int into a string and modifying the score in game
    public void setScore(int Score)
    {
        _score.text = Score.ToString();
    }
}
