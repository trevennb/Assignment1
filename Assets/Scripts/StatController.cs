using UnityEngine;
using System.Collections;
using UnityEngine.UI;

//StatController.cs
//Author: Trevenn Barthelot
//Last Modified by: Trevenn Barthelot on 10/30/2016
//Description: Controls the display on screen for health, points and game over

public class StatController : MonoBehaviour {
	[SerializeField]
	Text GameOverlbl = null;
	[SerializeField]
	Text Scorelbl = null;
	[SerializeField]
	Text Healthlbl = null;
	[SerializeField]
	GameObject player = null;


	// Initializes the scores as 0 and health at 100 and hides the game over label
	void Start () {

		Scorelbl.text = "Points: 0";
		Healthlbl.text = "Health: 100";
		Tracker.Instance.stat = this;
		GameOverlbl.gameObject.SetActive (false);

	}


	//Updates the score
	public void UpdatePoints(){

		Scorelbl.text = "Points: " + Tracker.Instance.Score;

	}

	//Updates the health
	public void UpdateHealth(){
		Healthlbl.text = "Health: " + Tracker.Instance.Health;
	}

	//Displays once health is 0
	public void GameOver(){
		player.SetActive (false);
		GameOverlbl.gameObject.SetActive (true);

	}
}
