using UnityEngine;
using System.Collections;

public class jousi : MonoBehaviour {

    public GameObject pallo;
    private Vector2 alkupaikka;
    private RaycastHit2D hit;
    public static bool alku;
    private float viritys;
    public GUITexture lataa;
    public PhysicsMaterial2D bounce;


	// Use this for initialization
	void Start () {

       alkupaikka = transform.position;
       alku = true;
	
	}
	
	// Update is called once per frame
	void Update () {


        if (!alku && Vector2.Distance(transform.position, pallo.transform.position) > 1f)
            {
     
                lataa.enabled = false;

            }
        else
            {
                lataa.enabled = true;

            }
    
        
        if (Input.GetKey("space") && (alku) && Vector2.Distance(transform.position, alkupaikka) < 4.5f)
        {
            
            transform.Translate(Vector3.down * 3f * Time.deltaTime);
            
        }
      
    if (Input.GetKeyUp("space"))
        {
            if (alku)
            {
                pallo.rigidbody2D.AddForce(Vector2.up * 5, ForceMode2D.Impulse);
            }
            alku = false;
            rigidbody2D.isKinematic = false;
            pallo.collider2D.sharedMaterial = bounce;

        }

        if (Vector2.Distance(transform.position, alkupaikka) < 0.1f)
        {

            rigidbody2D.isKinematic = true;

        }

        if (Input.touchCount > 0)
        {
            int i;

            for (i = 0; i < Input.touchCount; i++)
            {

                Touch touch = Input.GetTouch(i);


                if (lataa.HitTest(touch.position) && touch.phase == TouchPhase.Stationary && (alku) && Vector2.Distance(transform.position, alkupaikka) < 4.5)
                {

                    transform.Translate(Vector3.down * 3f * Time.deltaTime);


                }
                if (lataa.HitTest(touch.position) && touch.phase == TouchPhase.Ended)
                {
                    if (alku)
                    {
                        pallo.rigidbody2D.AddForce(Vector2.up * 5, ForceMode2D.Impulse);
                    }
                    alku = false;
                    rigidbody2D.isKinematic = false;
                    pallo.collider2D.sharedMaterial = bounce;

                }

            }
        }

	}
   
    void OnCollisionStay2D(Collision2D col)
    {

        alku = true;
        
        col.transform.parent= gameObject.transform;
        col.transform.localScale = gameObject.transform.localScale;
       
        
    }
    void OnCollisionExit2D(Collision2D col)
    {

        col.transform.parent = null;
      
        alku = false;
       

    }
  
  }

