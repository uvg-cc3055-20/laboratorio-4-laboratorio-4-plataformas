using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
				//Destroy (gameObject);
			}
		}	
	}
}
