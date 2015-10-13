using UnityEngine;
using System.Collections;

public class Hero_ammu : MonoBehaviour
{

    private GameObject uusiammus;
    private float hidaste = 0.3f;
    private float tulinopeus = 0;
    public GameObject kuula;
    private float ammuksen_nopeus;

    // Use this for initialization
    void Start()
    {

        ammuksen_nopeus = 0;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey("e") )
        {

            ammu();
        }

    }

   public void ammu()
    {
        if (Time.time > tulinopeus)
        {
            tulinopeus = hidaste + Time.time;
            uusiammus = (GameObject)Instantiate(kuula, transform.position, transform.rotation);

            if (Hero_liike.suunta)
                {
                    ammuksen_nopeus = 2;
                }
            else
                {
                    ammuksen_nopeus = -2;
                }
            uusiammus.rigidbody2D.AddForce(Vector2.right * ammuksen_nopeus, ForceMode2D.Impulse);
            Destroy(uusiammus, 3);
        }
    }

 
}
