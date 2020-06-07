using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimatilon : MonoBehaviour {

	private Animator theAnimator;

	// Use this for initialization
	void Awake() {

		theAnimator = transform.GetComponent<Animator> ();


	}//end method 

	private int checkforhorizontalinput(){

		int result = 0;

		if(Input.GetKey(KeyCode.LeftArrow))
		{
			result -= 1;

		}
		if(Input.GetKey(KeyCode.RightArrow))
		{
			result += 1;
		}


		Debug.Log ("Horizontal input: " + result);



		return result;

	}
	private int checkforverticalinput(){

		int result = 0;

		if(Input.GetKey(KeyCode.UpArrow))
		{
			result -= 1;

		}
		if(Input.GetKey(KeyCode.DownArrow))
		{
			result += 1;
		}


		Debug.Log ("Horizontal input: " + result);



		return result;

	}
	// Update is called once per frame
	void Update () 
	{
		int moveHorizontal = checkforhorizontalinput ();
		int moveVertical = checkforverticalinput ();

		if (moveHorizontal != 0 && moveVertical != 0) {

			if (theAnimator.GetBool ("sprinting") == false) {
				theAnimator.SetBool ("sprinting", true);



			}
		} 
		else 
		{
			if (theAnimator.GetBool ("sprinting")) {
				theAnimator.SetBool ("sprinting", false);

			}
		}if (moveHorizontal != 0) {

			if (theAnimator.GetBool ("sprinting") == false) {
				theAnimator.SetBool ("sprinting", true);



			}
		} 
		else 
		{
			if (theAnimator.GetBool ("sprinting")) {
				theAnimator.SetBool ("sprinting", false);

			}
		}

		if (Input.GetKey(KeyCode.UpArrow))
			{
				if (theAnimator.GetBool ("jump") == false){

				theAnimator.SetBool ("jump", true);
				}
			}
		 else 
			{
				
				if(theAnimator.GetBool("jump")){
				
			theAnimator.SetBool("jump", false);
				
				}	
		}//end else
			}//end method
			}//end class
