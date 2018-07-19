using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindZoneScript : MonoBehaviour {

    public Vector3 windForceDirection = Vector3.zero;
    public float windForce = 2f;

    private void OnTriggerStay(Collider other)
    {
        if(other.tag == "Ball")
        {
            other.attachedRigidbody.AddForce(windForceDirection * windForce);
        }
    }
}
