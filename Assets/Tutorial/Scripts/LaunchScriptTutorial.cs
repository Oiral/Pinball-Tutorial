using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchScriptTutorial : MonoBehaviour {

    public List<GameObject> objectsInRange = new List<GameObject>();

    public KeyCode launchButton = KeyCode.Space;

    public Vector3 force;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            objectsInRange.Add(other.gameObject);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (objectsInRange.Contains(other.gameObject))
        {
            objectsInRange.Remove(other.gameObject);
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(launchButton))
        {
            foreach (GameObject ball in objectsInRange)
            {
                ball.GetComponent<Rigidbody>().AddRelativeForce(force);
            }
        }
    }

    
}
