using System.Collections;
using UnityEngine;

public class Forum : MonoBehaviour {

	// Use this for initialization
	/* void Start () {
		
	} */
	
	// Update is called once per frame
	void Update () {
		
	}

	string url = "https://forum.unity.com/threads/unity3d-plugin-for-embedding-webpages-on-windows-is-ready.83071/";
	IEnumerator Start()
	{
		WWW www = new WWW(url);
		yield return www;
		Renderer renderer = GetComponent<Renderer>();
		renderer.material.mainTexture = www.texture;
	}
}