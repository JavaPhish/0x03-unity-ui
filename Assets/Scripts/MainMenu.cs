﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	// Loads scene related to given button
	public void PlayMaze() {
		SceneManager.LoadScene("maze");
	}
}