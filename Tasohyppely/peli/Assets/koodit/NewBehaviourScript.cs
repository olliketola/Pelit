using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {

	// Use this for initialization


    void awake() {

    
    }
	void Start () {

        

	}
	
	// Update is called once per frame
	void Update () {

        if (Hero_liike.elossa == false)
        {
         

            //kaikki kolikot takaisin aktiiviseksi
            for (int i = 0; i < transform.childCount; ++i)
            {
                this.transform.GetChild(i).gameObject.SetActive(true);
            }
        }
	}
}
