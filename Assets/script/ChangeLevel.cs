using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeLevel : MonoBehaviour {
	[SerializeField] private string newlevel;
	// Use this for initialization

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.CompareTag ("Player")) {
			SceneManager.LoadScene (newlevel);
		}
	}
}
