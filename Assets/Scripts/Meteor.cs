﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
 * Clase para que vaya generando meteoritos aleatoriamente
 * @author Ana Lucia Hernandez (17138). Esteban Cabrera (17781)
 * */
public class Meteor : MonoBehaviour {
	public GameObject meteor;
	private float scrollingSpeed = 7f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (GameController.instance.gameOver == false) {
			transform.Translate (Vector3.down * scrollingSpeed * Time.deltaTime);
			
			if (transform.position.y < -10) {
				Destroy (gameObject); //una vez el meteorito salga de pantalla, se destruye
			}
		}	
	}
}
