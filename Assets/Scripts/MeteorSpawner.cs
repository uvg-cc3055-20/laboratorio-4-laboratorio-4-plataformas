using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

			if (elapsedTime < spawnTime) {
				elapsedTime += Time.deltaTime;

			} else {
				float random = Random.Range (-7f, 7f);
				Instantiate (meteor, new Vector3 (random, 5, 0), Quaternion.identity);
				elapsedTime = 0f;	
			}
		}
		
	}
}
