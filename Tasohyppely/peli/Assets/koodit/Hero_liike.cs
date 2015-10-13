using UnityEngine;
using System.Collections;

public class Hero_liike : MonoBehaviour {

	private Animator anim;
    private bool testi = false;
    public static bool maassa = false;
    public static int hp = 100;
    public static int score = 0;
    public float nopeus;
	public static bool elossa = true;
    public float hyppy_teho = 400f;

    public static bool suunta;

    //tämä on "tyhjä" gameobject joka on varsinaisen hahmo objectin alla
	public Transform hahmo;
    //kosketusliike
    private Touch touch;
    public GUITexture vasen;
    public GUITexture oikea;
    public GUITexture hyppy;
    public GUITexture ammu;

	public static bool end = false;
	private RaycastHit2D hit;
    public static bool Hyppytesti;



	// Use this for initialization
	void Start () {

        suunta = true;
        elossa = true;
        anim = GetComponent<Animator>();
        anim.SetBool("liiku", false);
        anim.SetBool("juokse", false);
        anim.SetBool("dead", false);
        nopeus = 0f;

	}

	// Update is called once per frame
	void Update () {

        Hyppytesti = false;
        move();
        dead();
        
		Debug.DrawRay (hahmo.transform.position, Vector3.down);
        hit = Physics2D.Raycast(hahmo.transform.position, Vector3.down, 0.2f);
        
        if ((hit) && hit.collider.gameObject.tag == "pallo")
           
            {
                Hyppytesti = true;
                rigidbody2D.velocity = new Vector2(0, 13f);
             }

	}

   public void move()
    {

        // Liikkuminen
        if (Input.GetKey("d") && (elossa))

        {
            suunta = true;
			nopeus = 4;
            transform.right = new Vector2(1f, 0f);
			anim.SetBool("liiku", true);
            transform.position += Vector3.right * nopeus * Time.deltaTime;
		}

        else if (Input.GetKey("a") && (elossa))
        {

            suunta = false;
			nopeus = -4;
            transform.right = new Vector2(-1f,0f);
            transform.position += Vector3.right * nopeus * Time.deltaTime;
			anim.SetBool("liiku", true);
			
        }

        else
        {
			nopeus = 0;
            anim.SetBool("liiku", false);
        }
       //hyppääminen
        if (Input.GetKeyDown("space") && maassa == true && (elossa))
        {

            rigidbody2D.AddForce(Vector3.up * hyppy_teho);

        }
   

        // kosketus kontrollit

        if (Input.touchCount > 0)
        {

            int i;

            for (i = 0; i < Input.touchCount; i++)
            {

                touch = Input.GetTouch(i);



                if (touch.phase == TouchPhase.Stationary && ammu.HitTest(touch.position))
                {

                    GetComponent<Hero_ammu>().ammu();
                }

                if (touch.phase == TouchPhase.Stationary && oikea.HitTest(touch.position) && (elossa))
                {
                    suunta = true;
					nopeus = 4.0f;
                    transform.right = new Vector2(1f, 0f);
                    anim.SetBool("liiku", true);
                    transform.position += Vector3.right * nopeus * Time.deltaTime;
					
                }


                if (touch.phase == TouchPhase.Stationary && vasen.HitTest(touch.position) && (elossa))
                {
                    suunta = false;
					nopeus = 4.0f;
                    transform.right = new Vector2(-1f, 0f);
                    anim.SetBool("liiku", true);
                    transform.position -= Vector3.right * nopeus * Time.deltaTime;
					
                }

             
                if (touch.phase == TouchPhase.Began && hyppy.HitTest(touch.position) && maassa == true && (elossa))
                {

                    rigidbody2D.AddForce(Vector3.up * hyppy_teho);

                }
            }
          
        }//laskuri
    }//move


    //Kuolema
   void dead()
   {

       if (hp < 1)
       {

           anim.SetBool("dead", true);
           hp = 0;
           score = 0;
           Destroy(gameObject, 2);
           anim.SetBool("liiku", false);
           anim.SetBool("juokse", false);
           Destroy(GameObject.FindGameObjectWithTag("pommi"));
           elossa = false;

       }
   }

    void OnCollisionStay2D(Collision2D hit)
    {
            maassa = true;
    }
    void OnCollisionExit2D(Collision2D hit)
    {
            maassa = false;
    }
 
   void OnCollisionEnter2D(Collision2D hit)
    {

        if (hit.gameObject.tag == "enemy")
        {
            hp = hp - 25;
        }


        if (hit.gameObject.tag == "Moukari")
        {
            hp = hp - 100;
        }

        if (hit.gameObject.tag == "kivi")
        {
            hp = hp - 100;
        }


        if (hit.gameObject.tag == "pohja")
        {

            hp = 0;
       
        }

        if (hit.gameObject.tag == "loppu")
        {

            hit.gameObject.SetActive(false);
			end = true;

        }

		if (hit.gameObject.tag == "takaraja") {

			nopeus = 0f;

		}
        if (hit.gameObject.tag == "goblin")
        {

            hp = hp - 25;

        }
    }

     void OnTriggerEnter2D(Collider2D obj) {

         if (obj.gameObject.tag == "kolikko")
         {
             score++;
             obj.gameObject.SetActive(false);
         }
   
     }

   }



