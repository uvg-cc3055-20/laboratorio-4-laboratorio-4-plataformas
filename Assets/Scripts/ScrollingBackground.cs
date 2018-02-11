using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingBackground : MonoBehaviour {

	public float scrollingSpeed = 0.01f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (GameController.instance.gameOver == false) {
			// el background (osea los tiles) irán cambiando de posicion para dar la ilusión que la nave se está moviendo
			transform.Translate (new Vector3 (0, -1, 0) * scrollingSpeed * Time.deltaTime);
			if (transform.position.y < -9f) {
				transform.position = new Vector3 (transform.position.x, 9f, transform.position.z); 
			}
		}

	}
}
