using UnityEngine;
using UnityEngine.UI;

public class ManageScore : MonoBehaviour {
	
	public Transform player;
	public Text scoreText;


	void Update () {
		scoreText.text = player.position.z.ToString("0");
	}
}
