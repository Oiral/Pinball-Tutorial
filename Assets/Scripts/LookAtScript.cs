using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtScript : MonoBehaviour {

    public Transform lookingAtObject;
	
	// Update is called once per frame
	void Update () {
        Vector3 lookPos = transform.position - lookingAtObject.position;

        transform.rotation = Quaternion.LookRotation(lookPos, Vector3.up);
	}
}
