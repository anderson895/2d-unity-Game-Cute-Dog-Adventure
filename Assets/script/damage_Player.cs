using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class damage_Player : MonoBehaviour
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
        //Destroy (gameObject);

    
        if (col.tag == "Player")
        {
            Destroy(col.gameObject, 0.01f);


        }


    }
}