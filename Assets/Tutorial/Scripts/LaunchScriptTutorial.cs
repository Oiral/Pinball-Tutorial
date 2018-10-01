using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchScriptTutorial : MonoBehaviour {

    public List<GameObject> objectsInRange = new List<GameObject>();

    public KeyCode launchButton = KeyCode.Space;

    public Vector3 force = new Vector3(0,0,1);

    float currentPower;
    public float targetPower;
    public float pullSpeed;

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
        if (Input.GetKey(launchButton))
        {
            currentPower = Mathf.Lerp(currentPower, targetPower, pullSpeed * Time.deltaTime);
        }
        else if (Input.GetKeyUp(launchButton))
        {
            foreach (GameObject ball in objectsInRange)
            {
                ball.GetComponent<Rigidbody>().AddForce(force * currentPower,ForceMode.VelocityChange);
            }
            currentPower = 0;
        }
    }

    
}
