using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManagerScript : MonoBehaviour {

    public int Score;

    public Text scoreText;

    public GameObject RespawnPoint;

    public GameObject BallPrefab;

    public int ballsInPlay = 1;

    public GameObject endGamePanel;

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
            endGamePanel.SetActive(true);
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
}
