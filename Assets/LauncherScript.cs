using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LauncherScript : MonoBehaviour {

    public List<GameObject> objectsInTrigger = new List<GameObject>();

    public KeyCode launchButton = KeyCode.Space;

    public Vector3 force = new Vector3(0, 0, 1);

    float currentPower;
    public float maxPower;
    public float pullSpeed;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            objectsInTrigger.Add(other.gameObject);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (objectsInTrigger.Contains(other.gameObject))
        {
            objectsInTrigger.Remove(other.gameObject);
        }
    }

    // Update is called once per frame
    void Update () {
		if (Input.GetKey(launchButton))
        {
            currentPower += pullSpeed * Time.deltaTime;
            currentPower = Mathf.Clamp(currentPower, 0, maxPower);
            Debug.Log(currentPower);

        }else if (Input.GetKeyUp(launchButton))
        {
            foreach(GameObject ball in objectsInTrigger)
            {
                ball.GetComponent<Rigidbody>().AddForce(force * currentPower, ForceMode.VelocityChange);
            }
            currentPower = 0;
        }
	}
}
