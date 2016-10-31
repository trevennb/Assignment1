using UnityEngine;
using System.Collections;

//EnemyDamage.cs
//Author: Trevenn Barthelot
//Last Modified by: Trevenn Barthelot on 10/30/2016
//Description: Controls whether a player has collided with enemy

public class EnemyDamage : MonoBehaviour {

	public AudioSource[] Sounds;
	public AudioSource hit;

	//Enter this method once there is a collision with enemy object
	void OnTriggerEnter2D(Collider2D other)
	{
		//Decrease health, play hit sound and respawn if hit enemy 
		if (other.gameObject.tag == "Enemy") {
			Tracker.Instance.Health -= 10;
			Sounds = gameObject.GetComponents<AudioSource> ();

			hit = Sounds [1];

			hit.Play ();
			EnemyController EC = other.gameObject.GetComponent<EnemyController> ();

				EC.Reset ();

		}


	}
		
}
