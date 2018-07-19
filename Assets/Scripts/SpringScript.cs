using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpringScript : MonoBehaviour {

    public float activeStrength = 200f;
    public float unactiveStrength = 0f;

    public SpringJoint hitSpring;
    public SpringJoint pullBackSpring;

    public KeyCode inputKey = KeyCode.Space;

	// Update is called once per frame
	void Update () {
		if (Input.GetKey(inputKey))
        {
            //Activate our pull back spring
            pullBackSpring.spring = activeStrength;
            hitSpring.spring = unactiveStrength;
        }
        else
        {
            //Activate our hit spring
            pullBackSpring.spring = unactiveStrength;
            hitSpring.spring = activeStrength;
        }
	}
}
