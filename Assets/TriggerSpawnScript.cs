using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerSpawnScript : MonoBehaviour {

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            GameManager.instance.SpawnBall();
        }
    }
}
