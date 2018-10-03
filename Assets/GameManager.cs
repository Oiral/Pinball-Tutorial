using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public static GameManager instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }else if (instance != this)
        {
            Destroy(this);
        }
    }

    //Variables for the spawning of the ball
    public GameObject spawnLocation;
    public GameObject ballPrefab;


    //Variables for the score
    public int score;
    public Text scoreText;

    public int currentBallsAlive = 1;

    //Variables for health/lives
    public int lives = 3;
    public GameObject loseScreen;
    public Text livesText;
    public Text finalScoreText;
    public GameObject gameScreen;

    public void RemoveBall(GameObject ball)
    {
        Destroy(ball);
        currentBallsAlive -= 1;
        if (currentBallsAlive <= 0)
        {
            //Remove a life from the player
            lives -= 1;
            if (lives <= 0)
            {
                //End the game
                loseScreen.SetActive(true);
                gameScreen.SetActive(false);
                finalScoreText.text = score.ToString() + "000";
            }
            else
            {
                //Start a new round
                SpawnBall();
                UpdateUI();
            }
        }
    }

    private void UpdateUI()
    {
        scoreText.text = score.ToString() + "000";
        livesText.text = "Lives remaining - " + lives.ToString();
    }

    public void AddScore(int scoreToAdd)
    {
        score += scoreToAdd;
        UpdateUI();
    }
    

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            SpawnBall();
        }
    }

    public void SpawnBall()
    {
        //Create a new ball
        //Set position to ball spawn position
        Instantiate(ballPrefab, spawnLocation.transform.position, Quaternion.identity);
        currentBallsAlive += 1;
    }

    

    public void Quit()
    {
        Application.Quit();
        Debug.Log("Quit the game");
    }
}
