using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// References:
// in class code sample (CubeCtrl)
// https://docs.unity3d.com/ScriptReference/Input.GetMouseButtonDown.html
// https://www.youtube.com/watch?v=HgW-rAxnEqc

public class BoyAnimCtrl : MonoBehaviour {
	static Animator anim;
	public KeyCode moveUp;
	public KeyCode moveLeft;
	public KeyCode moveRight;
	private float speed = 10f;

	// take into consideration bar of collected bugs to transform
	// jar bugs perhaps

	void Start () {
		anim = GetComponent<Animator>();
		anim.SetBool("isWalking", false);
		anim.SetBool("isJumping", false);
		anim.SetBool("walkingBackwards", false);
	}
	
	void Update () {
		if (Input.GetKey(moveRight)) {
			transform.Translate(new Vector3(0, 0, 1)* speed * Time.deltaTime);
			anim.SetBool("isWalking", true);
		}
		else if (Input.GetKey(moveLeft)) {
            transform.Translate(new Vector3(0, 0, -1) * speed * Time.deltaTime);
        	anim.SetBool("walkingBackwards", true);
        }
		else if (Input.GetMouseButtonDown(0)) {
            Debug.Log("Pressed primary button.");
		}
		else {
			anim.SetBool("isWalking", false);
			anim.SetBool("walkingBackwards", false);
		}
		if (Input.GetKey(moveUp)) {
			transform.Translate(Vector3.up * 10 * Time.deltaTime);
		}
		if (transform.position.y < -13.5f) {
			FindObjectOfType<GameManager>().GameOver();
		}
	}

	void OnTriggerEnter(Collider other) {
		if (other.gameObject.tag == "bug") {
			other.gameObject.SetActive(false);
		}
	}
}
