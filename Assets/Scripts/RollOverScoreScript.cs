using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollOverScoreScript : MonoBehaviour {

    public int score = 2;

    public bool spawnBall = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Ball")
        {
            GameObject scoreObject = GameObject.FindGameObjectWithTag("GameController");
            ScoreManagerScript scoreScript = scoreObject.GetComponent<ScoreManagerScript>();
            scoreScript.AddToScore(score);

            if (spawnBall)
            {
                GameObject spawnerObject = GameObject.FindGameObjectWithTag("Spawner");
                BallSpawnerScript spawnerScript = scoreObject.GetComponent<BallSpawnerScript>();
                spawnerScript.SpawnBall();
            }

        }
    }
}
