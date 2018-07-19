using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PullScriptTutorial : MonoBehaviour {

    float activeStrength = 500f;
    float unactiveStrength = 0f;

    public string inputButtonName = "Pull";

    public SpringJoint restingSpring;
    public SpringJoint hitSpring;

    private void Update()
    {
        if (Input.GetButton(inputButtonName))
        {
            restingSpring.spring = activeStrength/5;
            hitSpring.spring = unactiveStrength;
        }
        else
        {
            restingSpring.spring = unactiveStrength;
            hitSpring.spring = activeStrength;
        }
    }
}
