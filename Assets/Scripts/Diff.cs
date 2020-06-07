using UnityEngine;
using UnityEngine.SceneManagement;

public class Diff : MonoBehaviour 
{
	// Use this for initialization
	public void NextScene()
	{
		SceneManager.LoadScene("Volcano");
	}

	public void NextScene2()
	{
		SceneManager.LoadScene("Difficulty");
	}

	public void NextScene3()
	{
		SceneManager.LoadScene("Volcano2");
	}
	public void NextScene4()
	{
		SceneManager.LoadScene("Leaderboards");
	}
	public void NextScene5()
	{
		SceneManager.LoadScene("MainMenu");
	}
}
