using UnityEngine;
using UnityEngine.UI;

public class Highscore : MonoBehaviour {
	
	public Text highscore;

	public void Start(){
		PlayerPrefs.GetInt ("HighScore", 0);
		highscore.text = PlayerPrefs.GetInt ("HighScore", 0).ToString();
	}
		
}
