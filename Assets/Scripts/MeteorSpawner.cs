using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * Clase para que vaya generando meteoritos aleatoriamente
 * @author Ana Lucia Hernandez (17138). Esteban Cabrera (17781)
 * */
public class MeteorSpawner : MonoBehaviour {
	public float spawnTime = 1.5f;
	public float elapsedTime = 0f;
	public GameObject meteor;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (GameController.instance.gameOver == false) {

			if (elapsedTime < spawnTime) { //va a ir generando nuevos dependiendo de cuanto tiempo ha pasado
				elapsedTime += Time.deltaTime;

			} else {
				float random = Random.Range (-7f, 7f);//llos generara en lugares aleatorios
				Instantiate (meteor, new Vector3 (random, 5, 0), Quaternion.identity);
				elapsedTime = 0f;	
			}
		}
		
	}
}
