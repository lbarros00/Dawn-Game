using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// References
// https://www.youtube.com/watch?v=_Z1t7MNk0c4

public class MinionCtrl : MonoBehaviour {
	static Animator animMinion;
	private float speed = 3f;
	private float stopDistance = 20f;

	public float timeBtwShots;
	public float startTimeBtwShots = 2f;
	public Vector3 startPosition;

	public GameObject projectile;
	public GameObject boy;
	private Transform player;

	void Start () {
		animMinion = GetComponent<Animator>();
		startPosition = transform.position;
		player = boy.transform;
		timeBtwShots = startTimeBtwShots;
	}
	
	void Update () {
		if (Vector3.Distance(transform.position, player.position) < stopDistance) {

            transform.Translate(new Vector3(0, 0, 1) * speed * Time.deltaTime);
			//Vector3 direction = new Vector3(transform.position.x, transform.position.y, transform.position.z);
			/*
			transform.position = Vector3.MoveTowards(
				direction, 
				player.position, 
				speed * Time.deltaTime);*/
			if (timeBtwShots <= 0) {
				animMinion.SetBool("attack", true);
				Instantiate(projectile, transform.position, Quaternion.identity);
				timeBtwShots = startTimeBtwShots;
			}
			else {	
				timeBtwShots -= Time.deltaTime;
			}
		}
		else {
			transform.position = startPosition;
		}
	}
}
