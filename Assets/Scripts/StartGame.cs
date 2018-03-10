using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour {

	public Button playButton;

	void Start () {
		Button btn = playButton.GetComponent<Button> ();
		btn.onClick.AddListener (PlayGame);
	}

	void PlayGame(){
		SceneManager.LoadScene("Level01", LoadSceneMode.Single);
	}

}
