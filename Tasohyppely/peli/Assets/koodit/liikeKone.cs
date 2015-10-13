using UnityEngine;
using System.Collections;

public class liikeKone : MonoBehaviour {

	// Use this for initialization
    public GameObject pommi;
    private GameObject uusiPommi;
    private int luku = 0;

    private float height;
    private float width;
    private float etureuna;
    private float takareuna;
    private float paikkaX;
    private float paikkaY;

	void Start () {


        paikkaX = this.transform.position.x;
        paikkaY = this.transform.position.y;
	}
	
	// Update is called once per frame
	void Update () {


        if (Hero_liike.elossa && !kamera_liike.paused) { 
        luku = Random.Range(0,10000);
        if (luku < 75)
        {
            Pudota();
        }

        if (transform.position.x > Camera.main.transform.position.x+10f) {

            transform.position = new Vector2(Camera.main.transform.position.x - Camera.main.orthographicSize*2,paikkaY);
        }

        transform.Translate(Vector3.right * 5f * Time.deltaTime);
    }
	}

    void Pudota() {

        uusiPommi = (GameObject)Instantiate(pommi, new Vector3(transform.position.x,transform.position.y,transform.position.z),transform.rotation);
    
        
    }

}
