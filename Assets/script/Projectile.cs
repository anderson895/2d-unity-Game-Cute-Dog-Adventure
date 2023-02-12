using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float weaponDamage;
    public float projectileSpeed;
    public GameObject impactEffect;

    private Rigidbody2D rigidbody;

    // Use this for initialization
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        rigidbody.velocity = transform.right * projectileSpeed;
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        Instantiate(impactEffect, transform.position, Quaternion.identity);
        //Destroy (col.gameObject, 1f);
        Destroy(gameObject);
        if (col.tag == "enemy")
        {
            //Destroy (col.gameObject,1f);
            enemyhealth hurtEnemy = col.gameObject.GetComponent<enemyhealth>();
            hurtEnemy.addDamage(weaponDamage);

        }
        if (col.tag == "wall")
        {
            ScoreScript.curscore += 1;
            Destroy(col.gameObject, 1f);
        }
    }
}
