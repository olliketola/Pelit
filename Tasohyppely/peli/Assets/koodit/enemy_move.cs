using UnityEngine;
using System.Collections;

public class enemy_move : MonoBehaviour {


    private RaycastHit2D hit;
    private RaycastHit2D hit1;

  
 
    public Hero_liike pelaaja;

    private Vector3 liike;
    private Vector3 liike2;
    private bool liiku = true;
    private Vector3 enemy_lahto_paikka;
    private float nopeus;
    
	// Use this for initialization
	void Start () {

        pelaaja = GetComponent<Hero_liike>();

        enemy_lahto_paikka = transform.position;

        
        nopeus = 1f;
	}
	
	// Update is called once per frame
	void Update () {

        

        liike = new Vector3(5f, 0f, 0f);
        hit = Physics2D.Raycast(transform.position, Vector3.left, 5f);
        hit1 = Physics2D.Raycast(transform.position, Vector3.right, 5f);
    
       
        Debug.DrawRay(transform.position, Vector3.left);
        Debug.DrawRay(transform.position, Vector3.right);

 

                if ((hit) && hit.collider.gameObject.tag == "hero" )
                {

                    transform.Translate(Vector3.right * 2f*Time.deltaTime);
            

                }

                if ((hit1) && hit1.collider.gameObject.tag == "hero" )
                {


                    transform.Translate(Vector3.left * 2f * Time.deltaTime);
               

                }


                Debug.Log(hit);

	}


    

}