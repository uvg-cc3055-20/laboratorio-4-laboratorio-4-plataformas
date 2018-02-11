using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameController : MonoBehaviour {
	public bool gameOver =false;
	private float score = 0f;
	public static GameController instance;
    

	// Use this for initialization
	void Start () {
		instance = this;
	}
	
	// Update is called once per frame
	void Update () {
		if (!GameController.instance.gameOver == false)
        {
			score += Time.deltaTime; // cambiara el score dependiendo de cuanto tiempo haya pasado vivo
        } 
	}
	public void EndGame()
	{
		GameController.instance.gameOver = true;
		float currentHighScore = PlayerPrefs.GetFloat ("Highscore");
		if (score > currentHighScore) {
			PlayerPrefs.SetFloat("Highscore", score); //en el caso que el score actual sea mayor que el highscore guardado
			// que se guarde el actual como el highscore
		}
	}
}
