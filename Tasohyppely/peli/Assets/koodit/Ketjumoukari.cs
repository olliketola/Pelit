using UnityEngine;
using System.Collections;

public class Ketjumoukari : MonoBehaviour
{

    public GameObject hero;
    public float matka = 12;
    private bool testi;
    private Vector2 paikka;
    private static bool palloirti;

    // Use this for initialization
    void Start()
    {


        transform.position = new Vector2(transform.position.x + 3f, transform.position.y + 5);
        rigidbody2D.isKinematic = true;
        paikka = transform.position;

    }

    // Update is called once per frame
    void Update()
    {
    
        palloirti = false;
        hero = GameObject.FindGameObjectWithTag("hero");

        if (hero != null)
        {

            if (Vector2.Distance(transform.position, hero.transform.position) < matka)
            {
                palloirti = true;

                rigidbody2D.isKinematic = false;

            }
          }
            

        if(hero == null)
       
        {
            transform.position = paikka;
            rigidbody2D.isKinematic = true;

        }

    }

}
