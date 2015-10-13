using UnityEngine;
using System.Collections;

public class Kaasu : MonoBehaviour
{


    private float maxNopeus = 10;
    public float nopeus = 25;
    private float massa;

    private Touch touch;
    public GUITexture vasen;
    public GUITexture oikea;
   
    // Use this for initialization
    void Start()
    {


        //rigidbody2D.centerOfMass = new Vector2(1 , -0.5f);
        massa = rigidbody2D.mass;

    }

    // Update is called once per frame
    void Update()
    {



        if (Input.GetKey("z"))
        {


            rigidbody2D.AddForce(Vector2.right * massa * 10f);


        }
        if (Input.GetKey("x"))
        {

            rigidbody2D.AddForce(Vector2.right * massa * -10);

        }

        if (Input.GetKey("c"))
        {



        }

        Debug.Log(rigidbody2D.velocity);




        if (Input.touchCount > 0)
        {

            int i;

            for (i = 0; i < Input.touchCount; i++)
            {

                touch = Input.GetTouch(i);



                if (touch.phase == TouchPhase.Stationary && oikea.HitTest(touch.position))
                {

                    rigidbody2D.AddForce(Vector2.right * massa * 10f);

                }


                if (touch.phase == TouchPhase.Stationary && vasen.HitTest(touch.position))
                {
                    rigidbody2D.AddForce(Vector2.right * massa * -10);

                }



            }

            
        }
        rigidbody2D.velocity = Vector2.ClampMagnitude(rigidbody2D.velocity, maxNopeus);

    }
}