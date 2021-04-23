# GameManagerBehaviour

public static GameManagerBehaviour Instance

use: gives objects a refference to the GameManagerBehaviour

private static bool _gameOver

use: bool used to end the game

private static bool _isPaused

use:bool used to determine if the game is paused or not

public static GameEvent onGameOver

use: to tell the game what to do once _gameOver is true

Public Text ScoreTextEdit

use: displays the score on the UI

public int Score

use: keeps track of score

private HealthBehaviour _playerHealth

use: to give refference to the player's health

private GameObject _gameOverScreen

use: manages the game over screen

private GameObject _pauseScreen

use: manages the pause screen

public static bool GameOver

use: to return _gameOver

public void PauseGame()

use: pauses the game

public void RestartGame()

use: restarts the game

public void QuitGame()

use: quits the game

public void IncrementScore()

use: adds the score after jumping over a wall

# HealthBehaviour

private float _health

use: health value for the actor

private bool _destroyOnDeath

use: destroys an actor on death

public float Health

use: returns _health

public void TakeDamage(float damage)

use: allows the actor to take damage

# ScoreBoxBehaviour

public ScoreTracker ScoreTracker

use: refference for the score tracker

public int Score

use: variable for score

private void OnTriggerEnter(Collider collision)

use: everytime the player enters this trigger zone the score will increase

public int getScore()

use: returns score

# WallSpawnBehaviour

public float TimeInterval

use: the time between the pipes

public bool GameOver

use: bool that determines if the game is over

public GameObject WallRef

use: reference to the pipes

public IEnumerator SpawnWalls()

use: spawns pipes

# JumpBehaviour

private RigidBody _rigidBody

use: reference for the player's rigidbody

public float JumpForce

use: the force that is applied on the player

private GameObject _playerRef

use: reference for the player

private HealthBehaviour _playerHealth

use: reference for the player health

# MovementBehaviour

public float HorizontalSpeed

use: sets the horizontal speed

public float StartCos

use: sets the start of the cosine to a value

# HealthBarBehaviour

private HealthBehaviour _health

use: variable for player's health

private Gradient _healthGradient

use: holds the health gradient

private Image _fill

use: holds the fill image

private Slider _slider

use: holds the slider variable

# ScoreTracker

private Text _score

use: holds the score text
