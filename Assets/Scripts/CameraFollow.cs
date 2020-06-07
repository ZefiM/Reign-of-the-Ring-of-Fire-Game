using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

	public GameObject player;

	public bool enableBounds = true;

	public float smoothTimeX = 0.2f, smoothTimeY = 0.2f;

	public Vector2 minCameraPos, maxCameraPos, velocity;

	public CameraFollowStyle style;

	// Update is called once per frame
	void LateUpdate () 
	{
		//Update our Camera
		if (enableBounds == true) 
		{

			switch(style)
			{
			//handles clamping camera to player
			case CameraFollowStyle.clamp:
				transform.position = new Vector3 (
					//x
					Mathf.Clamp(
						player.transform.position.x,
						minCameraPos.x,
						maxCameraPos.x
					),
					//y
					Mathf.Clamp(
						player.transform.position.y,
						minCameraPos.y,
						maxCameraPos.y
					),
					transform.position.z
				);
				break;

			//handle following player with smooth delay
			case CameraFollowStyle.smoothDamp:

				float targetX = Mathf.Max(minCameraPos.x,
					Mathf.Min(maxCameraPos.x, player.transform.position.x));

				float targetY= Mathf.Max(minCameraPos.y,
					Mathf.Min(maxCameraPos.y, player.transform.position.y));

				float posX = Mathf.SmoothDamp(
					transform.position.x,
					targetX,
					//player.transform.position.x,//(player locationm, follows player location)
					ref velocity.x,
					smoothTimeX
				);

				float posY = Mathf.SmoothDamp(
					transform.position.y,
					targetY,
					//player.transform.position.y,//(follows player location)
					ref velocity.y,
					smoothTimeY
				);

				float posZ = transform.position.z;

				transform.position = new Vector3 (posX, posY, posZ);


				break;
			}//end switch
		}//end if

		
	}//end method
}//end class

public enum CameraFollowStyle
{
	smoothDamp,
	clamp
}//end enum

