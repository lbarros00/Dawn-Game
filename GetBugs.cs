using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// References:
// https://answers.unity.com/questions/59934/how-to-an-object-floating-up-and-down.html?page=1&pageSize=5&sort=votes
// https://forum.unity.com/threads/adding-a-box-collider-by-script.67219/
// https://docs.unity3d.com/ScriptReference/GameObject.FindGameObjectsWithTag.html

public class GetBugs : MonoBehaviour {
	private float amplitude = 0.05f;
	private float speed = 5f;
	private float tempVal;
	public Vector3 tempPos;

	float scaleX = 7.199999f;
	float scaleY = 6.98f;
	float scaleZ = 46f;

	void Start () {
		foreach(GameObject bug in GameObject.FindGameObjectsWithTag("bug"))
		{
			if (GetComponent<BoxCollider>() == null) {
			    bug.AddComponent<BoxCollider>().size = new Vector3(
			    	scaleX, scaleY, scaleZ);
	        }
		}
    }
	
	void Update () {
		foreach(GameObject bug in GameObject.FindGameObjectsWithTag("bug"))
		{
			tempVal = bug.transform.position.y;
		    tempPos.x = bug.transform.position.x;
		    tempPos.z = bug.transform.position.z;
	        tempPos.y = tempVal + amplitude * Mathf.Sin(speed * Time.time);
 			bug.transform.position = tempPos;
		}
	}
}