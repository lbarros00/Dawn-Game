using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// References
// in class lecture

public class SceneCtrl : MonoBehaviour {
    public void SceneSwitcher() {
        SceneManager.LoadScene(1);
    }
}
