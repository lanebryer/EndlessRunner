﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Move : MonoBehaviour {

	public int playerSpeed = 10;
	private bool facingRight = false;
	public int playerJumpPower = 1250;
	private float moveX;
	
	// Update is called once per frame
	void Update () {
		PlayerMove ();

	}

	void PlayerMove ()
	{
		// CONTROLS
		moveX = Input.GetAxis ("Horizontal");
		if(Input.GetButtonDown ("Jump")){
			Jump();
		}
		// ANIMATIONS

		// PLAYER DIRECTION
		if (moveX < 0.0f && facingRight == false) {
			FlipPlayer();
		} else if (moveX > 0.0f && facingRight == true) {
			FlipPlayer();
		}

		// PHYSICS
		gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2 (moveX * playerSpeed, gameObject.GetComponent<Rigidbody2D>().velocity.y);
	}

	void Jump(){
		// JUMP CODE
		GetComponent<Rigidbody2D>().AddForce (Vector2.up * playerJumpPower);
	}

	void FlipPlayer(){
		facingRight = !facingRight;
		Vector2 localScale = gameObject.transform.localScale;
		localScale.x *= -1;
		transform.localScale = localScale;
	}
}
