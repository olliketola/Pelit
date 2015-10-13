using UnityEngine;
using System.Collections;

public class testi : MonoBehaviour {


    public GameObject cube;

	// Use this for initialization
	
	
	// Update is called once per frame
	void Update () {

        


        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray)) {

               Vector2 testi = ray.origin;
               cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
              
               cube.transform.position = testi;
            
            }
        }
	
	}
}
