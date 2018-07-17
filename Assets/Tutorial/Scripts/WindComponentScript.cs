using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider))]

public class WindComponentScript : MonoBehaviour {

    public Vector3 Force = Vector3.zero;

    List<GameObject> objectsInTunnel = new List<GameObject>();

    private void FixedUpdate()
    {
        for (int i = 0; i < objectsInTunnel.Count; i++)
        {
            Rigidbody body = objectsInTunnel[i].GetComponent<Rigidbody>();
            body.AddForce(Force);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        objectsInTunnel.Add(other.gameObject);
    }
    private void OnTriggerExit(Collider other)
    {
        objectsInTunnel.Remove(other.gameObject);
    }
}
