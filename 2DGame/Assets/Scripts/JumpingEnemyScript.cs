using UnityEngine;
using System.Collections;

public class JumpingEnemyScript : MonoBehaviour {
	float timer = 2;
	public float jumpForce = 1000f;
	private Rigidbody2D rb2d;
	private Material enemyColor;
	Color originalColor;
	// Use this for initialization
	void Start () {
		rb2d = GetComponent<Rigidbody2D>();
		enemyColor = GetComponent<MeshRenderer>().material;
		originalColor = enemyColor.color;
	}
	// Update is called once per frame
	void Update ()
	{
		timer -= Time.deltaTime;
		
		if (timer <= 1) 
		{
			enemyColor.color = Color.Lerp(originalColor, Color.magenta, 1 - timer); 
		}
		if (timer <= 0) 
		{
			int randNum = Random.Range (0, 2); 
			
			rb2d.AddForce(new Vector2(0f, jumpForce));
			enemyColor.color = originalColor;  
			if (randNum == 0)
				timer = 2;
			else
				timer = 4;
				
		}
			
			
	
	}
}
