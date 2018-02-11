﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

/** 
 * Esta sera la clase utilizada para cambiar entre el menú principal y la escena de la nave espacial 
 * 
 * @author Ana Lucia Hernandez (17138). Esteban Cabrera (17781)
 * 
 **/
public class SceneChanger : MonoBehaviour {
	public Text contadorText;

	// Use this for initialization
	void Start () {
		contadorText.text = PlayerPrefs.GetFloat ("Highscore").ToString(); // para que cambie el texto que aparece en el menu
		// por el highscore
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void OnStartGame()
	{
		SceneManager.LoadScene ("NaveEspacial"); //cambio de escenas
	}
}
