using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PullScript : MonoBehaviour {

    float activeStrength = 500f;
    float unactiveStrength = 1f;

    public string inputButtonName = "Pull";

    SpringJoint spring;

    private void Awake()
    {
        spring = GetComponent<SpringJoint>();
    }

    private void Update()
    {
        if (Input.GetButtonDown(inputButtonName))
        {
            spring.spring = activeStrength;
        }
        else
        {
            spring.spring = unactiveStrength;
        }
    }
}
