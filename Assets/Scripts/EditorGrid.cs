using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[ExecuteInEditMode]
public class EditorGrid : MonoBehaviour {
	public bool editorGridActive = true;
	private float x, y, z =0;
	public float cellSize = 1f;// is just default. Set this in inspector

	// Use this for initialization
	void Start () {
		//Debug.log("Start was run.");

	}
	
	// Update is called once per frame
	void Update () {
		//Debug.Log("Update is running.");
		if (!Application.isPlaying && editorGridActive) {
			if (cellSize <= 0)
			{
				cellSize = 0.0001f;
			}
			x = Mathf.Round (transform.position.x / cellSize) * cellSize;
			y = Mathf.Round (transform.position.x / cellSize) * cellSize;
			z = Mathf.Round (transform.position.x / cellSize) * cellSize;
			transform.position = new Vector3 (x, y, z);

		}		
	}
}
