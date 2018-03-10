using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

	bool gameHasEnded = false;
	public GameObject failedLevelUI;

	public void EndGame(){

		if (gameHasEnded == false) {
			
			gameHasEnded = true;
			failedLevelUI.SetActive (true);
		}
	}

	void Restart(){
		SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
	}
}
