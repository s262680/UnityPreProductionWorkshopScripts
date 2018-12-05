﻿using UnityEngine;
using System.Collections;

public class MainMenuScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void StartGame()
	{
		Application.LoadLevel ("MainScene");
	}

	public void Instructions()
	{
		Application.LoadLevel ("InstructionsScene");
	}

	public void Quit()
	{
		Application.Quit();
	}
}
