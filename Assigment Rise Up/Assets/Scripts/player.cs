﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class player : MonoBehaviour {

	public Rigidbody2D rb;

	private float score;
	public Text scoretext;
	private bool isdown;

	void Update(){
		if (Input.GetMouseButtonDown (0)) {

			isdown = true;
		} 
		if(Input.GetMouseButtonUp (0)){
		
			isdown = false;
		}

		if (isdown == true) {
			mousepostion ();
		} else {
		}
	}

	void FixedUpdate(){
	
		score++;
		scoretext.text = (score).ToString ();
	
	}

	void mousepostion(){
		Vector2 mousePos = Camera.main.ScreenToWorldPoint (Input.mousePosition);
		rb.position = mousePos;

	}


}