using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObjectScript : MonoBehaviour {

    public Vector3 axis = Vector3.up;
    public float rotateSpeed = 1f;
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(axis, rotateSpeed);
	}
}
