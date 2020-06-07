using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleTiles : MonoBehaviour {

	public Difficulty difficulty;
	public GameObject[] platforms;
	public int timerTileDelay =2;
	private int tilesMax;
	private int currentTile = 0;

	void Start()
	{
		if(difficulty != GameControl.control.difficulty)
		{
			Destroy (gameObject);
			return;
		}
		tilesMax = platforms.Length;

		foreach (GameObject go in platforms) 
		{
			go.SetActive (false);
		}
		StartCoroutine(StartTimeForTiles());


	}//end method


	//update is called once per frame
	void Update()
	{
		if(platforms[currentTile].activeSelf == false)
		{
			platforms[currentTile].SetActive(true);


				if (currentTile == 0) 
			{
				if(platforms[tilesMax-1].activeSelf)
						{
							platforms[tilesMax-1].SetActive(false);
					}
					}
					else 
					{ 
						if (platforms[currentTile-1].activeSelf)
						{platforms[currentTile-1].SetActive(false);
						}//end if
				}//end if
			}// end if
		
	}//end method



	private IEnumerator StartTimeForTiles()
	{
		bool flag = true;
		while(flag)
		{
			yield return new WaitForSeconds(timerTileDelay);

			currentTile++;

			if (currentTile == tilesMax)
			{
				currentTile = 0;
			}
			Debug.Log ("Current tile index: " + currentTile);
		}
		yield return null;
	//}//end method
	//private IEnumerator outCoroutine()
	//{
	//bool flag = true;
	//while(flag)
	//{
	//Debug.Log("Coroutine is running.");
	//yield return  WaitForSeconds(1);
//}//end loop
//yield return null;

}}


