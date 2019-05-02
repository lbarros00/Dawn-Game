using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// References
// https://www.youtube.com/watch?v=_Z1t7MNk0c4

public class ProjMovement : MonoBehaviour {
	private float speed = 5f;
	private Transform player;
	private Vector3 target;

	void Start () {
		player = FindObjectOfType<BoyAnimCtrl>().transform;
		target = new Vector3(player.position.x, player.position.y, player.position.z);
	}
	
	void Update () {
		transform.position = Vector3.MoveTowards(
			transform.position, 
			target, 
			speed * Time.deltaTime);
		
		if (transform.position == target) {
			DestroyProjectile();
		}
	}

	void OnTriggerEnter(Collider other) {
		if (other.CompareTag("boy")) {
			FindObjectOfType<HealthCtrl>().numHearts--;
			DestroyProjectile();
		}
	}

	void DestroyProjectile() {
		Destroy(gameObject);
	}
}
