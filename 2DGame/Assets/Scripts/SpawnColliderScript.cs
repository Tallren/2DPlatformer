using UnityEngine;
using System.Collections;

public class SpawnColliderScript : MonoBehaviour {
	public GameObject enemy;
	// Use this for initialization
	void Start () {
		
	}
	
	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.tag == "Player") 
		{
			Instantiate (enemy, transform.position, Quaternion.identity);
			Destroy(gameObject);
		}

	}
}
