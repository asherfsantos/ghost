﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovements : MonoBehaviour 
{
	private Rigidbody2D player;
	public float speed;
	public bool playerInPortal;
	public Sprite spiritSprite;
	public SpriteRenderer playerRenderer;
	public bool isLiving = true;
	

	void Start () 
	{
		player = GetComponent<Rigidbody2D>();
		playerRenderer = player.GetComponent<SpriteRenderer>();
	}
	
	void FixedUpdate()
	{
		float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis("Vertical");
		Vector2 movement = new Vector2 (moveHorizontal, moveVertical);
		player.AddForce(movement * speed);
	}

	void Update () 
	{
		
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.gameObject.CompareTag("Portal"))
		{
			isLiving = !isLiving;
			if(isLiving)
			{
				//living animation
			}
			else if(!isLiving)
			{
				//spirit animation
			}
		}
	}
}
