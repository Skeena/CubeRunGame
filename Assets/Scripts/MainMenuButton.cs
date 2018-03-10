using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class MainMenuButton : MonoBehaviour {

	public Button mainMenuButton;

	void Start(){
		Button btn = mainMenuButton.GetComponent<Button> ();
		btn.onClick.AddListener (ReturnToMainMenu);
	}

	void ReturnToMainMenu(){
		SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
	}


}
