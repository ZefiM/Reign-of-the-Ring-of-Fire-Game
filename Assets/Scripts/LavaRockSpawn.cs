using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LavaRockSpawn : MonoBehaviour {

	public GameObject LavaRockCollection;
	public float delay = 0.1f;
	public GameObject LavaRock;
	public float spawnTime = 2f;
	public float fallSpeed = 40.0f;
	private float timer =0;
	private int randomNumber;
	
	// Update is called once per frame
	void Update () {
		if ((GameControl.control.winGame != true) && (GameControl.control.deathofgeorge != true) && (GameControl.control.paused != true)) 
		{
			timer += Time.deltaTime;
			if (timer > spawnTime) {
				SpawnRandom ();
				timer = 0;
			}
		}
	}


	public void SpawnRandom()
	{
		Vector2 screenPosition = Camera.main.ScreenToWorldPoint (new Vector2 (Random.Range (600 , Screen.width + 400), Random.Range (1000, (Screen.height + 500))
		));                      //Camera.main.farClipPlane / 2
		Vector2 screenPositionBack = Camera.main.ScreenToWorldPoint (new Vector2 (Random.Range (-400 , Screen.width), Random.Range (1000, (Screen.height + 400))
		));
		GameObject rock1 = Instantiate (LavaRock, screenPosition, Quaternion.identity);
		GameObject rock2 = Instantiate (LavaRock, screenPositionBack, Quaternion.identity);

		rock1.transform.SetParent (LavaRockCollection.transform);
		rock2.transform.SetParent (LavaRockCollection.transform);
	}

}
