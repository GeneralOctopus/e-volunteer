using System.Collections;
using UnityEngine;

public class Forum : MonoBehaviour {

	// Use this for initialization
	/* void Start () {
		
	} */
	
	// Update is called once per frame
	void Update () {
		
	}

	public string url = "http://images.earthcam.com/ec_metros/ourcams/fridays.jpg";
	IEnumerator Start()
	{
		WWW www = new WWW(url);
		yield return www;
		Renderer renderer = GetComponent<Renderer>();
		renderer.material.mainTexture = www.texture;
	}
}