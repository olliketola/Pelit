using UnityEngine;
using System.Collections;

public class kamera2skene : MonoBehaviour {



    public Transform pelaaja;
    public Camera kamera;

    public GUIStyle customGuiStyle;
    public GUIStyle MenuItemStyle;

    private GameObject UusiHero;
    public Texture pause;
    public Texture play;
    private bool paused;
    private GUIStyle testStyle = new GUIStyle();
   

    private Vector2 velocity;
    private float smoothTime = -2f;
    private float smoothTime2 = 1f;



    // Use this for initialization
    void Start()
    {

        paused = false;


    }
    void OnGUI()
    {



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




      
    

    }

    // Update is called once per frame

    void Update()
    {




        kamera.transform.position = transform.position;

        //Kameran paikka
        var x = transform.position.x;
        var y = transform.position.y;



        x = Mathf.Lerp(x, pelaaja.transform.position.x, Time.deltaTime*10);

        y = Mathf.Lerp(y, pelaaja.transform.position.y, Time.deltaTime);

        //x = Mathf.SmoothDamp(transform.position.x, pelaaja.transform.position.x, ref velocity.x, smoothTime);


        //y = Mathf.SmoothDamp(transform.position.y, pelaaja.transform.position.y, ref  velocity.y, smoothTime2);
            
    




        transform.position = new Vector3(x, y, transform.position.z);

    }


    
}
