using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// References
// https://www.youtube.com/watch?v=yE0JdtVTnVk

public class ToggleMusic : MonoBehaviour {
	public AudioSource musicSource;

	void Start () {
		musicSource = GetComponent<AudioSource>();
	}

	void OnCollisionEnter(Collision other) {
		if (other.gameObject.tag == "boy") {
			musicSource.Play();
		}
	}
 }
