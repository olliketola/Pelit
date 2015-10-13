using UnityEngine;
using System.Collections;

public class teleport : MonoBehaviour {

 
    public GameObject t1;
    public GameObject t2;
    public GameObject t3;
   

	// Use this for initialization
	void Start ()
    {



    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter2D(Collision2D col){

        GameObject ball = GameObject.FindGameObjectWithTag("pallo");
    
        if (col.gameObject.tag == "pallo" && this.gameObject.tag == "t1")
        {
         
            ball.rigidbody2D.isKinematic = true;
            ball.transform.position = t2.transform.position + new Vector3(-1f, 1f, 0);
            ball.rigidbody2D.isKinematic = false;
            ball.rigidbody2D.AddForce(new Vector2(-1f,0f),ForceMode2D.Impulse);
        }

       if (col.gameObject.tag == "pallo" && this.gameObject.tag == "t2")
        {
            
            ball.rigidbody2D.isKinematic = true;
            ball.transform.position = t3.transform.position + new Vector3(1f,0f,0f);
            ball.rigidbody2D.isKinematic = false;
            ball.rigidbody2D.AddForce(new Vector2(1f, -1f), ForceMode2D.Impulse);
        }

      if (col.gameObject.tag == "pallo" && this.gameObject.tag == "t3")
        {
         
            ball.rigidbody2D.isKinematic = true;
            ball.transform.position = t1.transform.position + new Vector3(1f,1f,0f); ;
            ball.rigidbody2D.isKinematic = false;
            ball.rigidbody2D.AddForce(new Vector2(1f,1f),ForceMode2D.Impulse);
        }

    }
}
