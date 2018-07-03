using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ChangeScoreScriptTutorial : MonoBehaviour {

    public UnityEvent changeScore;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            changeScore.Invoke();
        }
    }


}
