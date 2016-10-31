using UnityEngine;
using System.Collections;

//PointsController.cs
//Author: Trevenn Barthelot
//Last Modified by: Trevenn Barthelot on 10/30/2016
//Description: Controls the spawning of rings

public class PointsController : MonoBehaviour {

	private Transform trnsfrm;
	private Vector2 currPos;

	private float miny = 1f;
	private float maxy = 5f;

	//Spawns first set of random rings
	void Start () {

		trnsfrm = gameObject.GetComponent<Transform>();
		currPos = trnsfrm.position;
		Reset ();

	}

	// Updates the position of the rings
	void FixedUpdate () {
		currPos = trnsfrm.position;

		currPos -= new Vector2 (0, 0);
		trnsfrm.position = currPos;

	}

	//Respawns the rings in random position as they get collected
	public void Reset(){
		float xpos = Random.Range (-44f, 66f);
		float ypos = Random.Range (miny, maxy);
		currPos = new Vector2 (xpos, ypos);
		trnsfrm.position = currPos;
	}
}
