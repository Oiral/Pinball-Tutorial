using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncerScript : MonoBehaviour {

    public float force = 10f;

    public float explosionRadius = 2f;

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(transform.position, explosionRadius);
    }

    private void OnCollisionEnter(Collision collision)
    {
        collision.rigidbody.AddExplosionForce(force, transform.position, 2);
    }
}
