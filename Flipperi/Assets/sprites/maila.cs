using UnityEngine;
using System.Collections;

public class maila : MonoBehaviour {

    public GameObject vasen;
    public GameObject oikea;

    public GUITexture vasenMaila;
    public GUITexture oikeaMaila;
   

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {

        Debug.Log(vasen.rigidbody2D.IsSleeping());

        //Kontorllit PC:lle
        if (Input.GetKey("q"))
        {

            vasen.rigidbody2D.AddForce((Vector3.up * 10f), ForceMode2D.Impulse);
           
        }

        if (Input.GetKey("w"))
        {
            oikea.rigidbody2D.AddForce((Vector3.up * 10f), ForceMode2D.Impulse);
           
        }

        //Kosketus kontorllit
   
        if (Input.touchCount > 0)
        {
            int i = 0;

            for (i = 0; i < Input.touchCount; i++)
            {

                Touch touch = Input.GetTouch(i);

                if (vasenMaila.HitTest(touch.position))
                {

                    vasen.rigidbody2D.AddForce((Vector3.up * 10f), ForceMode2D.Impulse);

                }
                if (oikeaMaila.HitTest(touch.position))
                {

                    oikea.rigidbody2D.AddForce((Vector3.up * 10f), ForceMode2D.Impulse);

                }


            }
        }//if touchcount
	}
}
