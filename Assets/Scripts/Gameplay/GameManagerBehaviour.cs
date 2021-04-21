using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public delegate void GameEvent();

public class GameManagerBehaviour : MonoBehaviour
{
    public static GameManagerBehaviour Instance;

    [SerializeField]
    private static bool _gameOver = false;

    [SerializeField]
    private static bool _isPaused = false;

    public static GameEvent onGameOver;

    public Text ScoreTextEdit;

    public int Score;

    [SerializeField]
    private HealthBehaviour _playerHealth;
    [SerializeField]
    private GameObject _gameOverScreen;
    [SerializeField]
    private GameObject _pauseScreen;

    public static bool GameOver
    {
        get
        {
            return _gameOver;
        }
    }

    public void PauseGame()
    {
        _isPaused = !_isPaused;
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(0);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void ChangePOV()
    {

    }

    public void IncrementScore()
    {
        Score ++;

        ScoreTextEdit.text = Score.ToString();
    }

    private void Start()
    {
        Instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        _gameOver = _playerHealth.Health <= 0;

        _gameOverScreen.SetActive(_gameOver);
        _pauseScreen.SetActive(_isPaused);
    }
}

/// <summary>
/// an example of a toggle
/// _isPaused = !isPaused
/// </summary>