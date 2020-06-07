using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerwalk : MonoBehaviour 
{

	public float movementMultiplier= 10.0f;

	private Rigidbody2D theRigidbody2D;


	public float jumpForce =1000f;

	private SpriteRenderer theSpriteRenderer;

	void Awake(){
		theRigidbody2D = transform.GetComponent<Rigidbody2D> ();
		theSpriteRenderer = transform.GetComponent<SpriteRenderer> ();

	}

	// Use this for initialization
	void Start () {
		
	}
	//int i = 0;
	// Update is called once per frame
	void Update () 

	{
		
		if ((GameControl.control.winGame != true) && (GameControl.control.deathofgeorge != true)) {
			//Debug.Log (i++);

			if (Input.GetKey (KeyCode.LeftArrow)) {
				transform.Translate (Vector2.left * movementMultiplier * Time.deltaTime);
				if (theSpriteRenderer.flipX != true)
					theSpriteRenderer.flipX = true;
				;
			}

			if (Input.GetKey (KeyCode.RightArrow)) {
				transform.Translate (Vector2.right * movementMultiplier * Time.deltaTime);
				if (theSpriteRenderer.flipX != false)
					theSpriteRenderer.flipX = false;
			}
			if (Input.GetKey (KeyCode.UpArrow) && theRigidbody2D.velocity.y.Equals (0)) {//jump
				theRigidbody2D.AddForce (new Vector2 (0f, jumpForce));
			}
		}


	}
	}

