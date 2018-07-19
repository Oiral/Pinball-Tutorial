using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObjectScript : MonoBehaviour {

    Vector3 startingPos;
    public float speed = 1f;
    public float moveHeight = 0.5f;
    public float offset = 1f;

	// Use this for initialization
	void Start () {
        startingPos = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 pos = startingPos;
        pos.y = pos.y + Mathf.Sin(Time.time * speed + offset) * moveHeight;

        transform.position = pos;
	}
}
