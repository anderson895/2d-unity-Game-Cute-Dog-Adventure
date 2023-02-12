using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyhealth : MonoBehaviour {

	public  float enemyMaxHealth;
	public float currentHealth;

	// Use this for initialization
	void Start () {
		currentHealth = enemyMaxHealth;
		
	}

	// Update is called once per frame
	void Update () {
		
	}

	public void addDamage(float damage){
		currentHealth -= damage;
		if (currentHealth <= 0) {
			makeDead ();
		}
	}
	void makeDead(){
		ScoreScript.curscore +=1;
		Destroy (gameObject); 
	}
	
}
