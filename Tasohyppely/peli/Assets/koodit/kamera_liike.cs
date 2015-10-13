using UnityEngine;
using System.Collections;

public class kamera_liike : MonoBehaviour
{


    // tähän spawnaa uusi hahmo
    public GameObject heroe;

    //hahmo joka on eka hengissä
    public Transform pelaaja;
    public Camera kamera;
    public GUIStyle customGuiStyle;
    public GUIStyle MenuItemStyle;

    private GameObject UusiHero;
    public Texture pause;
    public Texture play;
    static public bool paused;
    private GUIStyle testStyle = new GUIStyle();
    private Hero_liike hero;

    private Vector2 velocity;
    private float smoothTime = 0.3f;
    private float smoothTime2 = 0.3f;


    //Uuuden kentän luominen 
    public GameObject vanhamaa;
    private Vector3 vanhamaapaikka;
    public GameObject Uusimaa;
    private GameObject Uusikentta;

    //Luodaan uusi silta
    public GameObject vanhasilta;
    private Vector3 vanhasiltapaikka;
    public GameObject Uusisilta;
    private GameObject UusiSilta;

    public GameObject moukarinvarsi;


    // Use this for initialization
    void Start()
    {


        vanhamaapaikka = vanhamaa.transform.position;
        vanhasiltapaikka = vanhasilta.transform.position;
        paused = false;


    }
    void OnGUI()
    {


        MenuItemStyle = new GUIStyle(GUI.skin.button);
        MenuItemStyle.normal.textColor = Color.white;
        MenuItemStyle.hover.textColor = Color.green;
        MenuItemStyle.fontSize = 50;

        GUI.Label(new Rect(10, 35, 100, 20), "FPS" + 1.0f / Time.smoothDeltaTime, customGuiStyle);

        customGuiStyle = new GUIStyle(GUI.skin.box);
        customGuiStyle.normal.textColor = Color.black;


        GUI.Label(new Rect(10, 10, 100, 20), "Score: " + Hero_liike.score, customGuiStyle);
        GUI.Label(new Rect(115, 10, 100, 20), "Helth:" + Hero_liike.hp, customGuiStyle);


        //pause
        if (paused == false)
        {

            if (GUI.Button(new Rect(Screen.width - 60, 10, 50, 50), pause, testStyle))
            {

                Time.timeScale = 0.0f;
                paused = true;
            }
        }
        if (paused)
        {

            if (GUI.Button(new Rect(Screen.width - 60, 10, 50, 50), play, testStyle))
            {

                Time.timeScale = 1.0f;
                paused = false;
            }
        }


        if (Hero_liike.elossa == false)
        {

            if (GUI.Button(new Rect(Screen.width / 2 - 150, Screen.height / 2, 350, 100), "Retry", MenuItemStyle))
            {
                Hero_liike.elossa = true;
                Hero_liike.hp = 100;
                Destroy(GameObject.FindGameObjectWithTag("kaikkimaat"));
                Destroy(GameObject.FindGameObjectWithTag("silta"));
                UusiHero = (GameObject)Instantiate(heroe, new Vector3(-0.04778218f, 1.980248f, 0f), this.transform.rotation);
                Uusikentta = (GameObject)Instantiate(Uusimaa, vanhamaapaikka, this.transform.rotation);
                UusiSilta = (GameObject)Instantiate(Uusisilta, vanhasiltapaikka, this.transform.rotation);
                pelaaja = UusiHero.transform;

            }

        }

        if (Hero_liike.end)
        {

            if (GUI.Button(new Rect(Screen.width / 2 - 150, Screen.height / 2, 350, 100), "Next level", MenuItemStyle))
            {

                Application.LoadLevel("peliskene2");
                Hero_liike.end = false;
            }
        }

    }

    // Update is called once per frame

    void Update()
    {
      

        kamera.transform.position = transform.position;
        var x = transform.position.x;
        var y = transform.position.y;


        if ((Hero_liike.elossa))
        {


            x = Mathf.SmoothDamp(transform.position.x, pelaaja.transform.position.x, ref velocity.x, smoothTime);



        }

        transform.position = new Vector3(x, y, transform.position.z);


    }

 
 

  
}
