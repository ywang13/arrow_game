﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.Experimental.Director;

public class LevelManager : MonoBehaviour {
	public void LoadLevel(string name){
		SceneManager.LoadScene (name);
	}	

	public void playStartSound(AudioSource audio){
		audio.Play() ; 
	}

}
