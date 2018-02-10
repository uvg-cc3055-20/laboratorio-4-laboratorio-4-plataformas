using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingBackground : MonoBehaviour {

	public float scrollingSpeed = 5f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (new Vector3 (0, -1, 0) * scrollingSpeed * Time.deltaTime);
		if (transform.position.y >12f) {
			transform.position = new Vector3 (transform.position.x, 12f, transform.position.z); 
		}
	}
}
