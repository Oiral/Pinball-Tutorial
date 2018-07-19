using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BumperScript : MonoBehaviour {

    public int score = 1;

    public float explosiveForce = 150f;
    public float explosiveRange = 2f;

    public GameObject sparkPrefab;

    private void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireSphere(transform.position, explosiveRange);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            Debug.Log("EXPLOSION!!!");
            collision.rigidbody.AddExplosionForce(explosiveForce, transform.position, explosiveRange);

            GameObject scoreObject = GameObject.FindGameObjectWithTag("GameController");
            ScoreManagerScript scoreScript = scoreObject.GetComponent<ScoreManagerScript>();
            scoreScript.AddToScore(score);

            Instantiate(sparkPrefab, collision.contacts[0].point, Quaternion.identity, null);

        }
    }
}
