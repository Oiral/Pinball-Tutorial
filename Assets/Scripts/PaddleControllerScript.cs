using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleControllerScript : MonoBehaviour {

    //Variables
    public float restPosition = 0f;
    public float pressedPosition = 45f;

    public KeyCode paddleInput = KeyCode.Space;

    private float paddleStrength = 100000f;
    private float paddleDamper = 10f;

    private HingeJoint hinge;


	// Use this for initialization
	void Start () {
        hinge = GetComponent<HingeJoint>();
        hinge.useSpring = true;
	}
	
	// Update is called once per frame
	void Update () {
        JointSpring spring = new JointSpring();

        spring.spring = paddleStrength;
        spring.damper = paddleDamper;

        if (Input.GetKey(paddleInput))
        {
            //The code will run
            //Debug.Log("You have pressed space!!!!!!!!!!!");
            spring.targetPosition = pressedPosition;
        }
        else
        {
            spring.targetPosition = restPosition;
        }
        hinge.spring = spring;

	}
}
