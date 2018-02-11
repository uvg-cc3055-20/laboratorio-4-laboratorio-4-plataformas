using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Spaceship : MonoBehaviour {
	Rigidbody2D rb;
	public Camera cam;
	float speed = 10f;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D>();
		cam.transform.position = new Vector3(rb.transform.position.x, cam.transform.position.y, cam.transform.position.z);
	}
	
	// Update is called once per frame
	void Update()
	{
		//permite que la nave se mueva dependiendo de en que dirección está inclinado el teléfono
		float movX = Input.acceleration.x;
		rb.transform.Translate(Vector2.right * speed * movX * Time.deltaTime);
	}
	/**
	 * Se activará cuando la nave choque con uno de los meteoritos
	 **/
	private void OnTriggerEnter2D(Collider2D collision)
	{
		GameController.instance.gameOver = true;
		SceneManager.LoadScene ("StartMenu");
		GameController.instance.EndGame();
	}

}
