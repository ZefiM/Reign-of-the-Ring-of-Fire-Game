using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour
{
	public void NextScene()
	{
		SceneManager.LoadScene("Difficulty");
	}
}