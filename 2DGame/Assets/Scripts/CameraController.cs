using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	public Transform player;
	public Transform camera;
	public Vector3 cameraLoc;

	void Start ()
	{
		player = GameObject.FindWithTag("Player").transform;
		camera = GameObject.FindWithTag("MainCamera").transform;
	}

	void Update ()
	{
		if (player.position.x >= -4.6) 
		{
			cameraLoc = (new Vector3 (player.position.x, 9, -2));
			camera.position = cameraLoc;
		}
	}
}
