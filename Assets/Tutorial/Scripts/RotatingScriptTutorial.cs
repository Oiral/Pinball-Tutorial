using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingScriptTutorial : MonoBehaviour {

    public Vector3 axis = Vector3.up;
    public float speed;
	// Update is called once per frame
	void Update () {
        transform.Rotate(axis,speed);
	}
}
