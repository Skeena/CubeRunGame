using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class RestartButton : MonoBehaviour {
	
	public Button restartBtn;

	void Start(){
		Button btn = restartBtn.GetComponent<Button> ();
		btn.onClick.AddListener (RestartGame);
	}

	void RestartGame(){
		SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
	}
}
