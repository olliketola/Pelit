using UnityEngine;
using System.Collections;

public class scroll : MonoBehaviour {


	public Camera kamera;




	// Use this for initialization
	void Start () {


	}
	
	// Update is called once per frame
	void Update () {




		renderer.material.mainTextureOffset = new Vector2 (kamera.transform.position.x/25, 0f);	
		

}
}