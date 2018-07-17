using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatingScriptTutorial : MonoBehaviour {

    Vector3 startingPos;
    public float speed = 1;

	// Use this for initialization
	void Start () {
        startingPos = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 pos = startingPos;
        pos.y += Mathf.Sin(Time.time * speed);

        transform.position = pos;
	}
}
