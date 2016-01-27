using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour {

	public float speed;
	float moveVelocity;
	public bool startedMoving = false;
	bool facingLeft = true;
	public BoxCollider2D enemyCollider;




	// Use this for initialization
	void Start () {
		enemyCollider = GetComponent<BoxCollider2D>();
		
	}
	
	// Update is called once per frame

	void Update ()
	{
		if (facingLeft)
			moveVelocity = -speed;
		else
			moveVelocity = speed;

			GetComponent<Rigidbody2D> ().velocity = new Vector2 (moveVelocity, GetComponent<Rigidbody2D> ().velocity.y);
		
	}
	void OnTriggerEnter2D (Collider2D other)
	{
		
		if (other.tag == "Player") 
		{
			if (other.bounds.min.y < enemyCollider.bounds.max.y) 
			{
				Application.LoadLevel (Application.loadedLevel);
			} 
			else 
			{
				Destroy(gameObject);
			}
		}
		if (other.tag != "Ground" && other.tag != "Collider") {
			if (other.bounds.min.y < enemyCollider.bounds.max.y && other.bounds.max.y > enemyCollider.bounds.min.y)
			{
				facingLeft = !facingLeft;
			} 
			else 
			{
				facingLeft = true;
			}

		} 
	}
}
