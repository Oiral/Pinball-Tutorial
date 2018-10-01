using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleScript : MonoBehaviour {

    //Variable storage
    float restPostition = 0f;
    public float pressedPosition = 45f;
    public float paddleStrength = 10000f;
    float paddleDamper = 10f;

    public KeyCode inputKey = KeyCode.RightArrow;

    HingeJoint hinge;

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

        if (Input.GetKey(inputKey))
        {
            spring.targetPosition = pressedPosition;
        }
        else
        {
            spring.targetPosition = restPostition;
        }

        hinge.spring = spring;
        hinge.useLimits = true;

	}
}
