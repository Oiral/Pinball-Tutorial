using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class OutOfBoundsScript : MonoBehaviour {

    public UnityEvent outOfBounds;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            outOfBounds.Invoke();
            Destroy(other.gameObject,2f);
        }
    }
}
