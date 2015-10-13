using UnityEngine;
using System.Collections;

public class rengas : MonoBehaviour {


    private float nopeus = 0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey("z"))
        {

            nopeus++;
            Debug.Log(nopeus);
            rigidbody2D.velocity = Vector2.right * nopeus;
        }

        if (Input.GetKeyUp("z"))
        {

            nopeus = 0;
        }
    
	}
}
