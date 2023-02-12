using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyPatrol : MonoBehaviour
{
    public float speed; //define speed of enemy
    public float distance;  //define the distance detection of ground using raycast
    private bool moveRight = true; //define default direction of enemy
    public Transform groundDetection; //Defining the transform component of an object
    public Animator anim; //initialize animation component

    public int state = 1; //define the current state state 1= Patrol State 2 = attack

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (state == 1)
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
            RaycastHit2D groundinfo = Physics2D.Raycast(groundDetection.position, Vector2.down, distance);

            if (groundinfo.collider == false)
            { // detect if raycast is colliding with ground
                if (moveRight == true)
                {
                    transform.eulerAngles = new Vector3(0, -180, 0); // change direction to left
                    moveRight = false;
                }
                else
                {
                    transform.eulerAngles = new Vector3(0, 0, 0); // change direction to right
                    moveRight = true;
                }
            }
        }
        if (state == 2)
        {
            // Instruction when attacking
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "wall")
        {
            if (moveRight == true)
            {
                transform.eulerAngles = new Vector3(0, -180, 0);
                moveRight = false;
            }
            else
            {
                transform.eulerAngles = new Vector3(0, 0, 0);
                moveRight = true;
            }
        }
        if (col.tag == "enemy")
        {
            if (moveRight == true)
            {
                transform.eulerAngles = new Vector3(0, -180, 0);
                moveRight = false;
            }
            else
            {
                transform.eulerAngles = new Vector3(0, 0, 0);
                moveRight = true;
            }
        }
        if (col.tag == "Player")
        {
            state = 2;
            anim.SetInteger("state", 2);

        }

    }
    private void OnTriggerExit2D(Collider2D col)
    {
        if (col.tag == "Player")
        {
            state = 1;
            anim.SetInteger("state", 1);

        }

    }



}
