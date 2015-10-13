using UnityEngine;
using System.Collections;

public class testi : MonoBehaviour {

    public GameObject kamera;
    public BoxCollider2D col;
    private Vector2 max, min;
    private float kameramax, kameramin;

	// Use this for initialization
	void Start () {

        
        max = col.bounds.max;
        min = col.bounds.min;

        kameramax = Camera.main.orthographicSize * Screen.width / Screen.height;

        

	
	}
	
	// Update is called once per frame
	void Update () {

        var x = kamera.transform.position.x;
        var y = kamera.transform.position.y;

        //Debug.Log(min.y +";;;;" +max.y);

        if (y > max.y) {

            Debug.Log("kamera on ulkona kentält");
        }

         //x = (Mathf.Clamp(kamera.transform.position.x, min.x + kameramax, max.x-kameramax));
         //y = (Mathf.Clamp(kamera.transform.position.y, min.y + Camera.main.orthographicSize, max.y - Camera.main.orthographicSize));
         //kamera.transform.position = new Vector3(x, y, 0);
    }
}
