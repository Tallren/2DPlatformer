using UnityEngine;
using System.Collections;

public class JoustingController : MonoBehaviour {

	//joust killing
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.CompareTag("Enemy"))
		{
			Destroy(other.gameObject);
		}
	}
}
