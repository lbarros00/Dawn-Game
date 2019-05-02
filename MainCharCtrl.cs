using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// References:
// in class code sample (CubeCtrl)
// https://docs.unity3d.com/ScriptReference/Input.GetMouseButtonDown.html

public class MainCharCtrl : MonoBehaviour {
	public float speed = 5f;

	void Update () {
		if (Input.GetKey(KeyCode.RightArrow)) {
			transform.Translate(new Vector3(0,0,-1)* speed * Time.deltaTime);
		}
		if (Input.GetKey(KeyCode.LeftArrow)) {
            transform.Translate(new Vector3(0, 0, 1) * speed * Time.deltaTime);
        }
		if (Input.GetKey(KeyCode.UpArrow)) {
			transform.Translate(Vector3.up * speed * Time.deltaTime);
		}
		if (Input.GetKey(KeyCode.DownArrow)) {
			transform.Translate(Vector3.down * speed * Time.deltaTime);
		}
		if (Input.GetKey(KeyCode.DownArrow)) {
			transform.Translate(Vector3.down * speed * Time.deltaTime);
		}
		if (Input.GetMouseButtonDown(0)) {
            Debug.Log("Pressed primary button.");
		}
	}
}
