using UnityEngine;
using System.Collections;

public class Goblin_liiku : MonoBehaviour {


    private Animator anim;
    private Vector3 apaikka;
    private float nopeus;
    private RaycastHit2D hit;
    private RaycastHit2D hit2;
    private bool attack;

    private bool partio_testi;
  

	// Use this for initialization
	void Start () {

        anim = GetComponent<Animator>();
        apaikka = transform.position;
        transform.right = new Vector2(1, 0);
        anim.SetBool("lyo_goblin", false);
	}

    void OnGUI()
    {

        Vector2 targetPos;
        targetPos = Camera.main.WorldToScreenPoint(transform.position);

        GUI.Box(new Rect(targetPos.x, Screen.height/2, 60, 20), "örkki");
    }
 
	
	// Update is called once per frame
	void Update () {

        Debug.DrawLine(new Vector2(transform.position.x, transform.position.y - 0.2f), new Vector2(transform.position.x+3f, transform.position.y - 0.2f));
        Debug.DrawLine(new Vector2(transform.position.x, transform.position.y - 0.2f), new Vector2(transform.position.x- 3f, transform.position.y - 0.2f));

        hit = Physics2D.Linecast(new Vector2(transform.position.x, transform.position.y - 0.2f), new Vector2(transform.position.x+3f, transform.position.y - 0.2f));
        hit2 = Physics2D.Linecast(new Vector2(transform.position.x, transform.position.y - 0.2f), new Vector2(transform.position.x - 3f, transform.position.y - 0.2f));
       

        if ((hit) && hit.collider.gameObject.tag == "hero")
        {
            GameObject hero = GameObject.FindGameObjectWithTag("hero");

            transform.right = new Vector2(1,0);
            nopeus = 50;
         
                if(Vector2.Distance(hero.transform.position, this.transform.position) < 1f){

                    anim.SetBool("lyo_goblin", true);
                }

        }
        else if ((hit2) && hit2.collider.gameObject.tag == "hero")
        {
            GameObject hero = GameObject.FindGameObjectWithTag("hero");

            transform.right = new Vector2(-1, 0);
            nopeus = -50;

            if (Vector2.Distance(hero.transform.position, this.transform.position) < 1f)
            {

                anim.SetBool("lyo_goblin", true);
            }

        }

        else
        {

            anim.SetBool("lyo_goblin", false);

            if (Vector3.Distance(apaikka, transform.position) > 10f)
            {
                partio_testi = true;
                transform.right = new Vector2(-1, 0);
                nopeus = -50;


            }
            else if (Vector2.Distance(apaikka, transform.position) == 0)
            {
                partio_testi = true;
                transform.right = new Vector2(1, 0);
                nopeus = 50;
            }

            if (!partio_testi) {

                nopeus = 50;
            }
           
        }

      
        
        anim.SetBool("liiku_goblin", true);
        rigidbody2D.velocity = Vector3.right * nopeus* Time.deltaTime;

	
	}


    void partio() {


        
    }

    void OnCollisionEnter2D(Collision2D col){

        if (col.gameObject.tag == "ammus") {

            Destroy(gameObject);
            Destroy(col.gameObject);
         }

    }
     
}
