using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour {

	public static GameControl control = null;
	public bool winGame = false;
	public bool deathofgeorge = false;
	public bool paused = false;
	public int timeScore;
	public Difficulty difficulty;//set manually



	// Use this for initialization
	void Awake () {
		if (control != null) {
			
			Destroy (this);
		} else {
			control = this;
		}
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}//end class
