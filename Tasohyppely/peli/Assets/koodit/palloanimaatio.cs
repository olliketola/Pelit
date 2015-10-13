using UnityEngine;
using System.Collections;

public class palloanimaatio : MonoBehaviour {

    public Animator anim;
    


	// Use this for initialization
	void Start () {

        anim = GetComponent<Animator>();
        anim.SetBool("hyppy",false);
	}
	
	// Update is called once per frame
	void Update () {



        if (Hero_liike.Hyppytesti)
        {
            
            anim.SetBool("hyppy", true);
        }
        else {

            anim.SetBool("hyppy", false);

        }


	
	}
}
