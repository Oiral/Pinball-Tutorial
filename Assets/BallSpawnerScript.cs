using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawnerScript : MonoBehaviour {

    public GameObject ballPrefab;

    public void SpawnBall()
    {
        Instantiate(ballPrefab, transform.position, Quaternion.identity, null);
    }
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.K))
        {
            SpawnBall();
        }
	}
}
