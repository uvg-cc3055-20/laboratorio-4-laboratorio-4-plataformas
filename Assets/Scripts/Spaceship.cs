using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spaceship : MonoBehaviour {
	Rigidbody2D rb;
	public Camera cam;
	float speed = 0.05f;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D>();
		cam.transform.position = new Vector3(rb.transform.position.x, cam.transform.position.y, cam.transform.position.z);
		//anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update()
	{
		//Estos vectores dictan los límites de la pantalla, así el personaje no puede salirse de ella. 
		Vector3 minScreenBounds = Camera.main.ScreenToWorldPoint(new Vector3(0, 0, 0));
		Vector3 maxScreenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0));

		transform.Translate (Mathf.Clamp(Input.acceleration.x, minScreenBounds.x +1, maxScreenBounds.x -1), 0, 0);

		float movX = Mathf.Clamp(Input.acceleration.x, minScreenBounds.x +1, maxScreenBounds.x -1); 
		rb.transform.Translate(Vector2.right * speed * movX * Time.deltaTime);
		cam.transform.position = new Vector3(rb.transform.position.x, cam.transform.position.y, cam.transform.position.z);


	}

}
