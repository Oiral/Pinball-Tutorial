using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bb8headScript : MonoBehaviour {

    public Transform bb8Base;

    public float startingHeight;

    Rigidbody rb;

	// Use this for initialization
	void Start () {
        startingHeight = transform.position.y - bb8Base.transform.position.y;
        rb = bb8Base.GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        //transform.LookAt(rb.velocity + transform.position, Vector3.up);
        Vector3 lookPos = rb.velocity + transform.position;

        transform.rotation = Quaternion.Lerp(
            transform.rotation, 
            Quaternion.LookRotation(lookPos,Vector3.up), 
            10 * Time.deltaTime);

        Vector3 pos = bb8Base.transform.position;
        pos.y = pos.y + startingHeight;
        transform.position = pos;
	}
}
