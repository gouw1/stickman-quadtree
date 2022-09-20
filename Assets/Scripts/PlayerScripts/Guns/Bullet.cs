using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour, IHasID, IHasRect  {

	public float speed = 20f;
	public int damage = 40;
	public Rigidbody2D rb;
	//public GameObject impactEffect; //Play an effect on inpact
	public Rectangle rect { get; }
	public int ID { get; }

	// Use this for initialization
	void Start () {
		rb.velocity = transform.right * speed;
	}

	void OnTriggerEnter2D (Collider2D hitInfo)
	{
		Enemy enemy = hitInfo.GetComponent<Enemy>();
		if (enemy != null)
		{
			enemy.TakeDamage(damage);
		}

		//Instantiate(impactEffect, transform.position, transform.rotation);

		Destroy(gameObject);
	}
	
}