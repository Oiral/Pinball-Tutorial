using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawnerTutorial : MonoBehaviour {

    public List<GameObject> balls;
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.S))
        {
            Instantiate(balls[Random.Range(0, balls.Count)], transform.position, Quaternion.identity, null);
        }
	}
}
