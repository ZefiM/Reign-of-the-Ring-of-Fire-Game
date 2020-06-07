using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class goal : MonoBehaviour {

	//public bool winGame = false;

	// Use this for initialization
	void OnTriggerEnter2D(Collider2D coll) {

		if (GameControl.control.winGame != true) {
			if (coll.gameObject.tag == "Player") {
				GameControl.control.winGame = true;
				SceneManager.LoadScene ("Win");
				Debug.Log (GameControl.control.winGame);
			}
			//Debug.Log ("The game was won!");
			}
	}
}
