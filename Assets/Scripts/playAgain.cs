using UnityEngine;
using UnityEngine.SceneManagement;


public class playAgain : MonoBehaviour {

	// Use this for initialization
	public void NextScene()
	{
		SceneManager.LoadScene("Volcano");
	}

	public void NextScene2()
	{
		SceneManager.LoadScene("MainMenu");
	}
}
