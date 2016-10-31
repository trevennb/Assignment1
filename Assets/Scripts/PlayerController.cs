using UnityEngine;
using System.Collections;

//PlayerController.cs
//Author: Trevenn Barthelot
//Last Modified by: Trevenn Barthelot on 10/30/2016
//Description: Controls the players movement and jump behaviour

public class PlayerController : MonoBehaviour {
	[SerializeField]
	private float speed;
	private Rigidbody2D sonicRB = null;
	private Animator sonicAM = null;
	private bool rightDir;

	bool ground = false;
	float radGroundChk = 0.2f;
	public LayerMask groundLayer;
	public Transform groundCheck;
	public float jHeight;

	//References the rigidbody and the animation of the Sonic character and sets the direcion of facing right as true
	void Start () {
		sonicRB = gameObject.GetComponent<Rigidbody2D> ();
		sonicAM = gameObject.GetComponent<Animator> ();
		rightDir = true;
	}

	//Checks to see if the empty child ground is no longer on the ground and applies jump force
	void Update(){
		if (ground && Input.GetAxis ("Jump") > 0) {
			ground = false;
			sonicAM.SetBool ("isGround", ground);
			sonicRB.AddForce(new Vector2(0,jHeight));
		}
		
	}

	//Updates as the user presses left or right to move at set speed, also applies jump animation for falling or jumping(true for jump, false for fall)
	void FixedUpdate () {
		ground = Physics2D.OverlapCircle (groundCheck.position, radGroundChk, groundLayer);
		sonicAM.SetBool ("isGround", ground);

		sonicAM.SetFloat ("vSpeed", sonicRB.velocity.y);
		float move = Input.GetAxis ("Horizontal");
		
		sonicAM.SetFloat ("Speed", Mathf.Abs (move));
		sonicRB.velocity = new Vector2 (move * speed, sonicRB.velocity.y);

		//checks to see which direction user is heading to flip the character
		if (move > 0 && !rightDir) {
			turn ();
		} else if (move < 0 && rightDir) {
			turn ();
		}
	}

	//flip sprite method
	void turn(){
		rightDir = !rightDir;
		Vector3 scale = transform.localScale;
		scale.x = scale.x * -1;
		transform.localScale = scale;
	}
}
