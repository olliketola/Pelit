using UnityEngine;
using System.Collections;

public class Tuhoa_ammus : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter2D(Collision2D hit)
    {

        Destroy(gameObject);
        if (hit.gameObject.tag == "pommi") {

            Destroy(hit.gameObject);
        
        }

    }
}
