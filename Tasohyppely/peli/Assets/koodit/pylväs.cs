using UnityEngine;
using System.Collections;

public class pylväs : MonoBehaviour
{

    private JointMotor2D moottori;
    public SliderJoint2D sj;

    // Use this for initialization
    void Start()
    {

        moottori.motorSpeed = Random.RandomRange(200f,300f);
        moottori.maxMotorTorque = 10000;
        sj.motor = moottori;
    }

    // Update is called once per frame
    void Update()
    {
    

        if (sj.jointTranslation > -0.2f)
        {

            moottori.motorSpeed = sj.motor.motorSpeed;
            moottori.motorSpeed = moottori.motorSpeed * -1;

        }
        if (sj.jointTranslation < -2.7f)
        {

            moottori.motorSpeed = moottori.motorSpeed * -1;
        }

        sj.motor = moottori;
    }

    void OnCollisionEnter2D(Collision2D col)
    {

        if (col.gameObject.tag == "hero")
        {

            Hero_liike.hp = 0;

        }

    }
}
