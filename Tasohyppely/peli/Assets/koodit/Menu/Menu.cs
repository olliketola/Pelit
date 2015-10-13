using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnGUI(){

      if (GUI.Button(new Rect(Screen.width / 2-150, Screen.height / 2-50, 300, 100), "Aloita peli"))
            {
                Application.LoadLevel("peliskene");
                
            }
        }
}
