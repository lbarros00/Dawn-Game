using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Reference:
// https://www.youtube.com/watch?v=CHUOprBocoY
// https://answers.unity.com/questions/625683/how-can-i-count-the-number-of-instances-of-a-tagge.html

public class PickBugJar : MonoBehaviour {
	int count = 0;
	public GameObject inventory;
	public GameObject[] jars;

	void OnCollisionEnter(Collision collision) {
        Debug.Log("Bugs now:" + count);
		GameObject i;
		if (collision.gameObject.tag == "bug") {
			count++;
		}
		if (count == 1) {
			i = Instantiate(jars[0]);
			i.transform.SetParent(inventory.transform);
		}
		else if (count == 2) {
			i = Instantiate(jars[1]);
			i.transform.SetParent(inventory.transform);
		}
		else if (count == 3) {
			i = Instantiate(jars[2]);
			i.transform.SetParent(inventory.transform);
		}
	}
}
