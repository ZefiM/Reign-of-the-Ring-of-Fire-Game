using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class death : MonoBehaviour {



	//public bool winGame = false;


	// Use this for initialization
	void OnTriggerEnter2D(Collider2D coll) {

		if (coll.transform.gameObject.name == "george_11") {
			if (GameControl.control.deathofgeorge != true) {
				GameControl.control.deathofgeorge = true;
				SceneManager.LoadScene("Restart");
				Debug.Log (GameControl.control.deathofgeorge);
				//Debug.Log ("George Died!");
			}
		}
	}

}

