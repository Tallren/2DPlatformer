using UnityEngine;
using System.Collections;

public class FallingCollider : MonoBehaviour {
	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.CompareTag("Player"))
		{
				Application.LoadLevel(Application.loadedLevel);
		}
		else
		{
				Destroy(other.gameObject);
		}
	}
}
