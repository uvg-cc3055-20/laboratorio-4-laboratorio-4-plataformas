using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameController : MonoBehaviour {
	public bool gameOver =false;
	private int score = 0;
	public static GameController instance;
    public Text contadorText;

	// Use this for initialization
	void Start () {
		instance = this;
	}
	
	// Update is called once per frame
	void Update () {
		if (!GameController.instance.gameOver == false)
        {
			GameController.instance.score +=2;
			contadorText.text = "Score: " + GameController.instance.score.ToString();
        } 
	}
}
