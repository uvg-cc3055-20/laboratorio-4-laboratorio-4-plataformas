using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spaceship : MonoBehaviour {
	Rigidbody2D rb2d;
	public Camera cam;

	// Use this for initialization
	void Start () {
		rb2d = GetComponent<Rigidbody2D>();
		cam.transform.position = new Vector3(rb2d.transform.position.x, cam.transform.position.y, cam.transform.position.z);
		//anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update()
	{
		var x = Input.GetAxis("Horizontal") * Time.deltaTime * 7.0f;
		transform.Translate(x, 0, 0);
		var y = Input.GetAxis("Vertical") * Time.deltaTime * 7.0f;
		transform.Translate(0, y, 0);
	}

}
