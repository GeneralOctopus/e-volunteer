﻿using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LoadScene : MonoBehaviour {
    public string sceneName;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    LoadScene() {
        SceneManager.LoadScene(sceneName);
    }
}
