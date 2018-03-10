using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerObjectMovement : MonoBehaviour {

	public Rigidbody rb; //RigidBody Variable 

	public float forwardForce = 2000f;
	public float sideForce = 500f;
	public Text finalScoreText;
	public Text instructions;
	public float time = 4;

	IEnumerator Start ()
	{
		yield return new WaitForSeconds(time);
		instructions.enabled = false;
	}

	public void MoveLeftTouch(){
		rb.AddForce (-sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
	}

	public void MoveRightTouch(){
		rb.AddForce (sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
	}
		

	void moveRightKeyboard(){
		if (Input.GetKey("d")){
			rb.AddForce(sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
		}
	}

	void moveLeftKeyboard(){
		if (Input.GetKey("a")){
			rb.AddForce(-sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
		}
	}
				
	void FixedUpdate () {
		rb.AddForce (0, 0, forwardForce * Time.deltaTime); // Adds the forward force of the player

		moveLeftKeyboard ();
		moveRightKeyboard ();

		if (rb.position.y < -0.8f) {
			FindObjectOfType<GameManager> ().EndGame ();
			finalScoreText.fontSize = 28;
			finalScoreText.text = "Don't fall off next time..";
			instructions.enabled = false;
		}
	}
}
