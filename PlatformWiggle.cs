using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformWiggle : MonoBehaviour {
	private float amplitude = 0.2f;
	private float speed = 2f;
	private float tempVal;
	public Vector3 tempPos;

	void Update () {
		foreach(GameObject platform in GameObject.FindGameObjectsWithTag("platform"))
		{
			tempVal = platform.transform.position.y;
		    tempPos.x = platform.transform.position.x;
		    tempPos.z = platform.transform.position.z;
	        tempPos.y = tempVal + amplitude * Mathf.Sin(speed * Time.time);
 			platform.transform.position = tempPos;
		}
	}
}
