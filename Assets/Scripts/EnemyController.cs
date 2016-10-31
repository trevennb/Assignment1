using UnityEngine;
using System.Collections;

//EnemyController.cs
//Author: Trevenn Barthelot
//Last Modified by: Trevenn Barthelot on 10/30/2016
//Description: Controls enemy movement

public class EnemyController : MonoBehaviour {

	private Transform trnsfrm;
	private Vector2 currPos;

	private float miny = 1f;
	private float maxy = 5f;

	//Randomly spawns first set of enemies
	void Start () {

		trnsfrm = gameObject.GetComponent<Transform>();
		currPos = trnsfrm.position;
		Reset ();

	}

	// Speed of enemies moving right to left
	void FixedUpdate () {
		currPos = trnsfrm.position;

		currPos -= new Vector2 (0.1f, 0);
		trnsfrm.position = currPos;

		//Respawn emeny once they dissapear off field of view
		if (currPos.x <= -60) {
			Reset ();
		}

	}

	//Spawns enemeies outside stage in random position
	public void Reset(){
		float xpos = Random.Range (66f, 166f);
		float ypos = Random.Range (miny, maxy);
		currPos = new Vector2 (xpos, ypos);
		trnsfrm.position = currPos;
	}
}
