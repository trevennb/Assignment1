using UnityEngine;
using System.Collections;

//StatController.cs
//Author: Trevenn Barthelot
//Last Modified by: Trevenn Barthelot on 10/30/2016
//Description: Controls the collection of rings

public class PointsCollect : MonoBehaviour {

	public AudioSource[] Sounds;
	public AudioSource rings;

	//Enter this method once there is a collision with ring object
	void OnTriggerEnter2D(Collider2D other)
	{
		//Increase score, play ring sound and respawn if collected ring 
		if (other.gameObject.tag == "Rings") {
			Tracker.Instance.Score++;
			Sounds = gameObject.GetComponents<AudioSource> ();
			rings = Sounds [0];


			rings.Play ();

			PointsController PC = other.gameObject.GetComponent<PointsController> ();
			PC.Reset ();


		}
	}
}
