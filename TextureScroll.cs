using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// References:
// https://www.youtube.com/watch?v=auVq3TSz20o

public class TextureScroll : MonoBehaviour {
    public float scrollX = 0.01f;

	void Update () {
        float offSetX = Time.time * scrollX;
        // make sure background move backwards with boy
        /*
        if (FindObjectOfType<BoyAnimCtrl>().speed == 0) {

        }*/
        GetComponent<Renderer>().material.mainTextureOffset = new Vector2(offSetX,0);
    }
}
