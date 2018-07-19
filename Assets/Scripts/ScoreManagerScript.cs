using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManagerScript : MonoBehaviour {

    public int score;

    public Text scoreText;

    public void AddToScore(int scoreToAdd)
    {
        score = score + scoreToAdd;
        scoreText.text = "Score: " + score + "000";
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            AddToScore(5);
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("Application trying to quit");
            Application.Quit();
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            Debug.Log("Loading scene 0");
            SceneManager.LoadScene(0);
        }
    }

}
