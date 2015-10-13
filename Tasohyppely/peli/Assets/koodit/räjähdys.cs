using UnityEngine;
using System.Collections;

public class räjähdys : MonoBehaviour {

    public ParticleSystem tuli;
    private GameObject tuhottava_objekti;


	// Use this for initialization
	void Start () {

    }



	
	// Update is called once per frame
	void Update () {
	

	}


    void toista()
    {
        tuli.Play();
        Destroy(tuhottava_objekti);
    }

    void OnCollisionEnter2D(Collision2D hit)
    {


        if (hit.collider.tag == "maa")
        {

            Invoke("toista", 4);
            Destroy(gameObject, 5);
          tuhottava_objekti = hit.gameObject;


        }

        if (hit.collider.tag == "hero")
        {
            if (tuli.isPlaying)
            {
                Hero_liike.hp = Hero_liike.hp - 100;
            }

        }

    }


    void OnCollisionStay2D(Collision2D hit)
    {

        if (hit.collider.tag == "hero" && tuli.isPlaying)
        {
      
            Hero_liike.hp = Hero_liike.hp - 100;
        }

    }

  }//main

    
