using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleScriptTutorial : MonoBehaviour {

    //Parameters
    float restPosition = 0f;
    public float pressedPosition = 45f;
    float paddleStrength = 10000f;
    float paddleDamper = 10f;

    public string inputButtonName = "RightPaddle";

    HingeJoint hinge;

    private void Awake()
    {
        hinge = GetComponent<HingeJoint>();
        hinge.useSpring = true;
    }

    private void Update()
    {
        JointSpring spring = new JointSpring();
        spring.spring = paddleStrength;
        spring.damper = paddleDamper;


        if (Input.GetButton(inputButtonName))
        {
            spring.targetPosition = pressedPosition;
        }
        else
        {
            spring.targetPosition = restPosition;
        }
        hinge.spring = spring;
        hinge.useLimits = true;
    }
}
