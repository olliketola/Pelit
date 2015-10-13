using UnityEngine;
using System.Collections;

public class sarana : MonoBehaviour
{

    private GameObject hero;
    private GameObject kivi;
    private Vector2 alkupaikka;
    private Quaternion alkurotatio;
    private Vector2 alkupaikkaKivi;

    // Use this for initialization
    void Start()
    {
        kivi = GameObject.FindGameObjectWithTag("kivi");
        alkupaikka = transform.position;
        alkurotatio = transform.rotation;
        alkupaikkaKivi = kivi.transform.position;

    }

    // Update is called once per frame
    void Update()
    {

        hero = GameObject.FindGameObjectWithTag("hero");

        if (hero != null)
        {

            if (Vector2.Distance(transform.position, hero.transform.position) < 7f)
            {

                rigidbody2D.isKinematic = false;
                kivi.rigidbody2D.isKinematic = false;
                
            }
        }

        if (!Hero_liike.elossa) {

            //resetointi
        
                rigidbody2D.isKinematic = true;
                kivi.rigidbody2D.isKinematic = true;
                transform.rotation = alkurotatio;
                transform.position = alkupaikka; 
                kivi.transform.position = alkupaikkaKivi;

        }

    }
}