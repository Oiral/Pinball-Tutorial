using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BumperScriptTutorial : MonoBehaviour {

    public int score = 1;

    public float explosiveForce = 150f;
    public float explosiveRadius = 0.5f;

    private void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireSphere(transform.position, explosiveRadius);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Boom");
        collision.rigidbody.AddExplosionForce(explosiveForce, transform.position, explosiveRadius);

        ScoreManagerScript scoreManager = GameObject.FindGameObjectWithTag("GameController").GetComponent<ScoreManagerScript>();
        scoreManager.AddToScore(score);
    }
}
