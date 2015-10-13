using UnityEngine;
using System.Collections;

public class pallo : MonoBehaviour {

	// Muuttujat
    public GameObject palkki;
    private Vector2 alkupaikka;
	private GameObject UusiPallo;
	public GameObject palloPre;
    public Light valo1;
    public Light valo2;
    public Light valo3;
    public Light valoBumber1;
    public Light valoBumber2;
    public GameObject loppuvalo;
    private Light valo_alussa;
    public static float pisteet;
    private Color[] varit;
    private int arvottu;
    bool arvo;
    public static bool loppu;
    private PhysicsMaterial2D none = null;
 
    
	void Start () {

        // Tarvittavat alustukset
        loppuvalo.SetActive(false);
        pisteet = 0;
        alkupaikka = transform.position;
        arvo = false;
        varit = new Color[5];
        varit[0] = Color.blue;
        varit[1] = Color.red;
        varit[2] = Color.yellow;
        varit[3] = Color.green;
        varit[4] = Color.cyan;
	}
	
	// Update is called once per frame
	void Update () {

        
       //värien vaihto
        if (arvo)
        {
            arvottu = Random.Range(0, varit.Length);
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }

    }


      void OnCollisionEnter2D(Collision2D coll) {

          // Törmäyksien tutkiminnen ja niihin regointi
          if (coll.gameObject.tag == "kimmoke1")
          {

              rigidbody2D.isKinematic = true;
              rigidbody2D.isKinematic = false;
              arvo = true;
              pisteet += 25;
              Debug.Log("osu");
              valo1.color = varit[arvottu];
              rigidbody2D.AddForce(new Vector2(Random.Range(-2, 2), Random.Range(-2, 2)), ForceMode2D.Impulse);
             
          }

          if (coll.gameObject.tag == "kimmoke2")
          {

              rigidbody2D.isKinematic = true;
              rigidbody2D.isKinematic = false;
              arvo = true;
              pisteet += 50;
              Debug.Log("osu");
              valo2.color = varit[arvottu];
              rigidbody2D.AddForce(new Vector2(Random.Range(-2, 2), Random.Range(-2, 2)), ForceMode2D.Impulse);
              

          }

         if (coll.gameObject.tag == "kimmoke3")
          {

              rigidbody2D.isKinematic = true;
              rigidbody2D.isKinematic = false;
              pisteet += 25;
              Debug.Log("osu");
              valo3.color = varit[arvottu];
              rigidbody2D.AddForce(new Vector2(Random.Range(-2, 2), Random.Range(-2, 2)), ForceMode2D.Impulse);


          }

          if (coll.gameObject.tag == "pohja")
          {

              collider2D.sharedMaterial = none;
              rigidbody2D.isKinematic = true;
              loppu = true;
              Invoke("reset", 3f);
              Debug.Log("loppu");
              loppuvalo.SetActive(true);
   
          }

          if (coll.gameObject.tag == "bumber1")
          {
              rigidbody2D.isKinematic = true;
              rigidbody2D.isKinematic = false;
              pisteet += 5;
              rigidbody2D.AddForce(new Vector2(Random.Range(-2, 2), Random.Range(-2, 2)), ForceMode2D.Impulse);
              valoBumber1.intensity = 1.5f;

          }
          else {
              valoBumber1.intensity = 0.9f;
          }

          if (coll.gameObject.tag == "bumber2")
          {
              rigidbody2D.isKinematic = true;
              rigidbody2D.isKinematic = false;
              valoBumber2.intensity = 1.5f;
              pisteet += 5;
              rigidbody2D.AddForce(new Vector2(Random.Range(-5, 5), Random.Range(-5, 5)), ForceMode2D.Impulse);
              valoBumber2.intensity = 1.5f;

          }
          else {
              valoBumber2.intensity = 0.9f;
          }

    }

    //pelin restointi
      void reset() {

          pisteet = 0;
          loppuvalo.SetActive(false);
          rigidbody2D.isKinematic = false;
          jousi.alku = true;
          transform.position = alkupaikka;
          
      }
}
