﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuCont : MonoBehaviour {

	void Start () {
		
	}
	
	public void StartGame () {
        SceneManager.LoadScene("MainScene");
	}
}
