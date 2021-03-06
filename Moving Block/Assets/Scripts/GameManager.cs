﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	bool ended = false;
	public float restartDelay = 1.5f;
	public GameObject complete;
	
	public void FinishLevel()
	{
		complete.SetActive (true);
	}
	
	public void EndGame()
	{
		if (ended == false)
		{
			ended = true;
			Debug.Log ("GAME OVER");
			Invoke ("Restart", restartDelay);
		}
	}
	
	void Restart()
	{
		SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
	}
}
