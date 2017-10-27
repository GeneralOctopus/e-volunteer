using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LoadScene : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    LoadScene(string sceneName) {
        SceneManager.LoadScene(sceneName);
    }
}
