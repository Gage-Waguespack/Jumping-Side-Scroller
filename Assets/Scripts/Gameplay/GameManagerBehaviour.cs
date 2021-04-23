using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public delegate void GameEvent();

public class GameManagerBehaviour : MonoBehaviour
{
    //Created a GameManagerBehaviour variable so I can give objects a refference to the GameManagerBehaviour
    public static GameManagerBehaviour Instance;

    //A bool used to end the game
    [SerializeField]
    private static bool _gameOver = false;

    //A bool used to pause the game
    [SerializeField]
    private static bool _isPaused = false;

    //A GameEvent to tell the game what to do when the game ends
    public static GameEvent onGameOver;

    //Used to track the Scores text edit
    public Text ScoreTextEdit;

    //A variable to keep track of the score
    public int Score;

    //Serialized variable to track player health
    [SerializeField]
    private HealthBehaviour _playerHealth;

    //Serialized variable used to manage the game over screen
    [SerializeField]
    private GameObject _gameOverScreen;

    //Serialized variable used to manage the pause screen
    [SerializeField]
    private GameObject _pauseScreen;

    //Bool to get Game over
    public static bool GameOver
    {
        get
        {
            return _gameOver;
        }
    }

    //a toggle used to pause and unpause the game
    public void PauseGame()
    {
        _isPaused = !_isPaused;
    }

    //Restarts the game by calling the scene
    public void RestartGame()
    {
        SceneManager.LoadScene(0);
    }

    //Quits the game by calling Application.Quit
    public void QuitGame()
    {
        Application.Quit();
    }

    //Adds to the score after jumping over a wall
    public void IncrementScore()
    {
        //adds one to score when called
        Score ++;

        //edits the score in game
        ScoreTextEdit.text = Score.ToString();
    }

    private void Start()
    {
        //Sets instance to equal GameManagerBehaviour
        Instance = this;
    }

    void Update()
    {
        //Slows time to near 0 to simulate pausing time
        if (_isPaused)
            Time.timeScale = 0.0000001f;

        //once _isPaused is false it returns the game to it's normal speed
        else
            Time.timeScale = 1;

        //Sets _gameOver to be true if the players health reaches zero or below
        _gameOver = _playerHealth.Health <= 0;

        //Pauses the game when the player is dead
        _gameOverScreen.SetActive(_gameOver);
        _pauseScreen.SetActive(_isPaused);
    }
}

/// <summary>
/// an example of a toggle
/// _isPaused = !isPaused
/// </summary>