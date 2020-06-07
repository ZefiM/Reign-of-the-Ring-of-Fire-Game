using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour 
{
	public static Timer time = null;
	private float seconds = 0.2f;
	private int seconds2;
	public Text Timertxt;
	public string endTime;
	public int zero = 0;

	// Use this for initialization
	void Awake () {
		if (time != null) {
			Destroy (this);
		} else {
			time = this;
		}

	}

	public void Update()
	{
		if (GameControl.control.paused == false) {
			seconds += Time.deltaTime;
		} else
			return;
		seconds2 = Mathf.RoundToInt(seconds);
		if (seconds2 == 1) 
		{
			endTime = seconds2 + " Second";
			Timertxt.text = endTime;
			GameControl.control.timeScore = seconds2;
		} else 
			if (seconds2 > 1) 
			{
				endTime = seconds2 + " Seconds";
				Timertxt.text = endTime;
				GameControl.control.timeScore = seconds2;
			}
	}

}
