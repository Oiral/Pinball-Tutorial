using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerLoseLifeScript : MonoBehaviour {

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            GameManager.instance.RemoveBall(other.gameObject);
        }
    }
}
