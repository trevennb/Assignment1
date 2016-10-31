using UnityEngine;
using System.Collections;

//CameraController.cs
//Author: Trevenn Barthelot
//Last Modified by: Trevenn Barthelot on 10/30/2016
//Description: Controls the movement of the camera

public class CameraController : MonoBehaviour {
	[SerializeField]
	Transform target = null;

	void Start () {
	
	}

	//Poitions the camera to follow the horizontal and vertical movement of the charcter
	void Update () {
		gameObject.transform.position = new Vector3(target.position.x, target.position.y, transform.position.z);
	}
}
