using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonHandler : MonoBehaviour {

	public GameObject pauseCanvas;
	public GameObject[] objectToDisabled;

	// Use this for initialization

	void Awake () {
		pauseCanvas.SetActive(false);
	}
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		if (Input.GetKeyDown (KeyCode.P)) {
			if (pauseCanvas.activeSelf == false) {
				pauseCanvas.SetActive (true);
				ToggleGameObjects (false);
				GameControl.control.paused = true;
			} else {
				pauseCanvas.SetActive (false);
				ToggleGameObjects (true);
				GameControl.control.paused = false;
			}
		}

	}

	public void DisablePause(){
		pauseCanvas.SetActive (false);
		ToggleGameObjects (true);
		GameControl.control.paused = false;
	}
	//public void EnablePause()
	//{
	//	pauseCanvas.SetActive(true);
	//}
	public void GotoMainMenu()
	{
		SceneManager.LoadScene ("MainMenu", LoadSceneMode.Additive);
	}

	private void ToggleGameObjects(bool flag)
	{
		foreach (GameObject go in objectToDisabled)
			
		{
			go.SetActive (flag);
		}
	}
}
