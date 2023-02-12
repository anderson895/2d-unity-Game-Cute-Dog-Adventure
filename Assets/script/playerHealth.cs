using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class playerHealth : MonoBehaviour
{
    public float playerMaxHealth;
    public float pcurrentHealth;
    float edamage;
    float edagdag;

  

    // Use this for initialization
    void Start()
    {
        pcurrentHealth = playerMaxHealth;

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D col)
    {

      


        if (col.tag == "enemy")
        {
            enemyAttack attackdamage = col.gameObject.GetComponent<enemyAttack>();
            edamage = attackdamage.attack1Damage;
            pcurrentHealth -= edamage;
            Debug.Log(edamage);
            if (pcurrentHealth <= 0)
            {

                makeDead();
                SceneManager.LoadScene("loseScreen");

            }
        }

        if (col.tag == "tikbalang1")
        {
            enemyAttack attackdamage = col.gameObject.GetComponent<enemyAttack>();
            edamage = attackdamage.attack1Damage;
            pcurrentHealth -= edamage;
            Debug.Log(edamage);
            if (pcurrentHealth <= 0)
            {

                makeDead();
                SceneManager.LoadScene("loseScreen");

            }
        }



        if (col.tag == "tikbalang2")
        {
            enemyAttack attackdamage = col.gameObject.GetComponent<enemyAttack>();
            edamage = attackdamage.attack1Damage;
            pcurrentHealth -= edamage;
            Debug.Log(edamage);
            if (pcurrentHealth <= 0)
            {

                makeDead();
                SceneManager.LoadScene("loseScreen");

            }
        }

        if (col.tag == "tikbalang3")
        {
            enemyAttack attackdamage = col.gameObject.GetComponent<enemyAttack>();
            edamage = attackdamage.attack1Damage;
            pcurrentHealth -= edamage;
            Debug.Log(edamage);
            if (pcurrentHealth <= 0)
            {

                makeDead();
                SceneManager.LoadScene("loseScreen");

            }
        }
        if (col.tag == "takbalang3")
        {
            enemyAttack attackdamage = col.gameObject.GetComponent<enemyAttack>();
            edamage = attackdamage.attack1Damage;
            pcurrentHealth -= edamage;
            Debug.Log(edamage);
            if (pcurrentHealth <= 0)
            {

                makeDead();
                SceneManager.LoadScene("loseScreen");

            }
        }
        if (col.tag == "BlackDarna")
        {
            enemyAttack attackdamage = col.gameObject.GetComponent<enemyAttack>();
            edamage = attackdamage.attack1Damage;
            pcurrentHealth -= edamage;
            Debug.Log(edamage);
            if (pcurrentHealth <= 0)
            {

                makeDead();
                SceneManager.LoadScene("loseScreen");

            }
        }

        if (col.tag == "kapre2")
        {
            enemyAttack attackdamage = col.gameObject.GetComponent<enemyAttack>();
            edamage = attackdamage.attack1Damage;
            pcurrentHealth -= edamage;
            Debug.Log(edamage);
            if (pcurrentHealth <= 0)
            {

                makeDead();
                SceneManager.LoadScene("loseScreen");

            }
        }

        if (col.tag == "valentina1")
        {
            enemyAttack attackdamage = col.gameObject.GetComponent<enemyAttack>();
            edamage = attackdamage.attack1Damage;
            pcurrentHealth -= edamage;
            Debug.Log(edamage);
            if (pcurrentHealth <= 0)
            {

                makeDead();
                SceneManager.LoadScene("loseScreen");

            }
        }
        if (col.tag == "manananggal1")
        {
            enemyAttack attackdamage = col.gameObject.GetComponent<enemyAttack>();
            edamage = attackdamage.attack1Damage;
            pcurrentHealth -= edamage;
            Debug.Log(edamage);
            if (pcurrentHealth <= 0)
            {

                makeDead();
                SceneManager.LoadScene("loseScreen");

            }
        }

        if (col.tag == "manananggal2")
        {
            enemyAttack attackdamage = col.gameObject.GetComponent<enemyAttack>();
            edamage = attackdamage.attack1Damage;
            pcurrentHealth -= edamage;
            Debug.Log(edamage);
            if (pcurrentHealth <= 0)
            {

                makeDead();
                SceneManager.LoadScene("loseScreen");

            }
        }
        if (col.tag == "Kapre1")
        {
            enemyAttack attackdamage = col.gameObject.GetComponent<enemyAttack>();
            edamage = attackdamage.attack1Damage;
            pcurrentHealth -= edamage;
            Debug.Log(edamage);
            if (pcurrentHealth <= 0)
            {

                makeDead();
                SceneManager.LoadScene("loseScreen");

            }
        }
        if (col.tag == "manananggal3")
        {
            enemyAttack attackdamage = col.gameObject.GetComponent<enemyAttack>();
            edamage = attackdamage.attack1Damage;
            pcurrentHealth -= edamage;
            Debug.Log(edamage);
            if (pcurrentHealth <= 0)
            {

                makeDead();
                SceneManager.LoadScene("loseScreen");

            }
        }

        if (col.tag == "manananggal4")
        {
            enemyAttack attackdamage = col.gameObject.GetComponent<enemyAttack>();
            edamage = attackdamage.attack1Damage;
            pcurrentHealth -= edamage;
            Debug.Log(edamage);
            if (pcurrentHealth <= 0)
            {

                makeDead();
                SceneManager.LoadScene("loseScreen");

            }
        }

        if (col.tag == "manananggal6")
        {
            enemyAttack attackdamage = col.gameObject.GetComponent<enemyAttack>();
            edamage = attackdamage.attack1Damage;
            pcurrentHealth -= edamage;
            Debug.Log(edamage);
            if (pcurrentHealth <= 0)
            {

                makeDead();
                SceneManager.LoadScene("loseScreen");

            }
        }

        if (col.tag == "manananggal7")
        {
            enemyAttack attackdamage = col.gameObject.GetComponent<enemyAttack>();
            edamage = attackdamage.attack1Damage;
            pcurrentHealth -= edamage;
            Debug.Log(edamage);
            if (pcurrentHealth <= 0)
            {

                makeDead();
                SceneManager.LoadScene("loseScreen");

            }
        }


        if (col.tag == "valentina2")
        {
            enemyAttack attackdamage = col.gameObject.GetComponent<enemyAttack>();
            edamage = attackdamage.attack1Damage;
            pcurrentHealth -= edamage;
            Debug.Log(edamage);
            if (pcurrentHealth <= 0)
            {

                makeDead();
                SceneManager.LoadScene("loseScreen");

            }
        }

        if (col.tag == "valentina boss")
        {
            enemyAttack attackdamage = col.gameObject.GetComponent<enemyAttack>();
            edamage = attackdamage.attack1Damage;
            pcurrentHealth -= edamage;
            Debug.Log(edamage);
            if (pcurrentHealth <= 0)
            {

                makeDead();
                SceneManager.LoadScene("loseScreen");

            }
        }
        if (col.tag == "tikbalang5")
        {
            enemyAttack attackdamage = col.gameObject.GetComponent<enemyAttack>();
            edamage = attackdamage.attack1Damage;
            pcurrentHealth -= edamage;
            Debug.Log(edamage);
            if (pcurrentHealth <= 0)
            {

                makeDead();
                SceneManager.LoadScene("loseScreen");
              
            }
        }

      

       




     
    }

    void makeDead()
    {

       
        Destroy(gameObject);
        
    }
}