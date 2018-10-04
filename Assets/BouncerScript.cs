using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncerScript : MonoBehaviour {

    public float force = 10f;

    public float explosionRadius = 2f;

    public int bouncerWorth = 1;

    public GameObject sparksPrefab;

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(transform.position, explosionRadius);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (sparksPrefab != null)
        {
            Instantiate(sparksPrefab, transform).transform.position = transform.position;
        }
        collision.rigidbody.AddExplosionForce(force, collision.contacts[0].point, 2);
        GameManager.instance.AddScore(bouncerWorth);
    }
}
