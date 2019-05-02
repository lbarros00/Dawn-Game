using UnityEngine;
using UnityEngine.SceneManagement;

// References
// https://www.youtube.com/watch?v=VbZ9_C4-Qbo

public class GameManager : MonoBehaviour {
	bool gameEnded = false;

	public void GameOver() {
		if (gameEnded == false) {
			gameEnded = true;
			SceneManager.LoadScene(2);
		}
	}
}
