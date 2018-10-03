using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerPointScript : MonoBehaviour {

    public int triggerWorth = 1;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            GameManager.instance.AddScore(triggerWorth);
        }
    }
}
