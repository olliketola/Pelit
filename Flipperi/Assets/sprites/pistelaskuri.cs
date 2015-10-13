using UnityEngine;
using System.Collections;

public class pistelaskuri : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnGUI() {

        GUI.Label(new Rect(10, 10, 150, 100), "Pisteet:" + pallo.pisteet);
            
    
    }
}
