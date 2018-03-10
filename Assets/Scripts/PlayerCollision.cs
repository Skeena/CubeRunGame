using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCollision : MonoBehaviour {

	public PlayerObjectMovement movement;
	public Transform playerobject;


	public Text highScore;
	public Text finalScore;
	public Text currentScore;
	public Text instructions;


	public void Start(){
		highScore.text = PlayerPrefs.GetInt ("HighScore", 0).ToString();
	}
		
	public void OnCollisionEnter(Collision collisionInfo){
		if (collisionInfo.collider.tag == "Obstacle") {

			int number = Mathf.RoundToInt (playerobject.position.z);
			finalScore.text = number.ToString ();

			if (number > PlayerPrefs.GetInt ("HighScore", 0)) 
			{
				PlayerPrefs.SetInt ("HighScore", number);
				highScore.text = number.ToString ();
			}
				
			movement.enabled = false;
			currentScore.enabled = false;
			instructions.enabled = false;


			FindObjectOfType<GameManager> ().EndGame ();
		}
	}
}
