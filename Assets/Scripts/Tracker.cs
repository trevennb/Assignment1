using UnityEngine;
using System.Collections;

//StatController.cs
//Author: Trevenn Barthelot
//Last Modified by: Trevenn Barthelot on 10/30/2016
//Description: Conrols the update of points and health

public class Tracker {

	private int score = 0;
	private int health = 100;

	public StatController stat;

	private static Tracker _instance = null;

	//get method for use of the tracker instance
	public static Tracker Instance{

		get{ 
			if (_instance == null) {

				_instance = new Tracker ();
			}
			return _instance;
		}
	}

	private Tracker(){
	}

	//get and set method for use and call for update of points
	public int Score{
		get{ 
			return score;
		}

		set{ 
			score = value;

			//trigger UI update
			stat.UpdatePoints();
		}
	}

	//get and set method for use and call for update of healh and game over method if health is 0
	public int Health{
		get{ 
			return health;
		}

		set{ 
			health = value;

			//trigger UI update
			stat.UpdateHealth();
			if (health <= 0) {
				stat.GameOver ();
			}
		}
	}
}
