using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayTime : MonoBehaviour {

	public Text Timertxt;
	// Update is called once per frame
	public void Update () 
	{
		//Debug.Log (GameControl.control.timeScore);
		Timertxt.text = Timer.time.endTime;
	}//end OnGUI method(Similar to update method)
}

