using UnityEngine;
using System.Collections;

public class apu : MonoBehaviour

{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


    }

     void OnCollisionEnter2D(Collision2D coll) {
    
        Debug.Log("osuu");
        Hero_liike.maassa = true;
        coll.transform.parent = gameObject.transform;

    }
     void OnCollisionExit2D(Collision2D coll)
     {

         Hero_liike.maassa = false;
         Debug.Log("ei osu");
         coll.transform.parent = null;

     }

}