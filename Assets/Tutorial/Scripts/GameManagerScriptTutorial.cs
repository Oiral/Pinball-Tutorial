using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManagerScriptTutorial : MonoBehaviour {

    //All variables dealing with the score
    public int Score;

    public Text scoreText;

    //All variables dealing with the balls
    public GameObject RespawnPoint;

    public GameObject BallPrefab;

    public int ballsInPlay = 1;


    //All variables dealing with the lose state
    public int lives = 3;

    public GameObject loseScreen;

    //create a singleton of GameManagerScriptTutorial
    public static GameManagerScriptTutorial instance;

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

    public void AddScore(int toAdd)
    {
        Score += toAdd;
        UpdateUI();
    }

    public void RemoveScore(int toRemove)
    {
        Score -= toRemove;
        if (Score < 0)
        {
            Score = 0;
        }
        UpdateUI();
    }

    private void UpdateUI()
    {
        scoreText.text = Score.ToString();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            SpawnBall();
        }

        if (ballsInPlay <= 0)
        {
            loseScreen.SetActive(true);
        }
    }

    void SpawnBall()
    {
        Instantiate(BallPrefab, RespawnPoint.transform.position, Quaternion.identity, null);
        ballsInPlay += 1;
    }

    public void RemoveBall()
    {
        ballsInPlay -= 1;
    }

    public void Restart()
    {
        SceneManager.LoadScene(0);
    }

    public void LoseLife()
    {
        lives -= 1;
        //Check if we have lost the game
        if (lives <= 0)
        {
            //Toggle the end screen
            loseScreen.SetActive(true);
        }
    }
}
