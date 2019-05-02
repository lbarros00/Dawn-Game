using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// References
// In class Canvas lecture
// https://www.youtube.com/watch?v=3uyolYVsiWc

public class HealthCtrl : MonoBehaviour {
	public int health;
	public int numHearts;

	public Image[] hearts;
	public Sprite heart;

	void Update () {
		if (health > numHearts) {
			health = numHearts;
		}

		for (int i = 0; i < hearts.Length; i++) {
			if (i < numHearts) {
				hearts[i].enabled = true;
			}
			else {
				hearts[i].enabled = false;
			}
		}

		if (numHearts == 0) {
			FindObjectOfType<GameManager>().GameOver();
		}
	}
}
