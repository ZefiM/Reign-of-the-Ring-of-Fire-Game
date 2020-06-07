using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveUserName : MonoBehaviour {

	public string username;
	public InputField InputUser;

	public void submit()
	{
		if (InputUser.text != "") 
		{
			username = InputUser.text;
			Highscores.AddNewHighscore (username, GameControl.control.timeScore);
		} else
			return;
		
	}


}
