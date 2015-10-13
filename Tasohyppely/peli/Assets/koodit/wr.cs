using UnityEngine;
using System.Collections;

public class wr : MonoBehaviour
{

    private JointMotor2D motor;
    private HingeJoint2D hj;

    void Start()
    {

        hj = GetComponent<HingeJoint2D>();
        motor.maxMotorTorque = 1000;
        motor.motorSpeed = 100;
        hj.motor = motor;

    }

    // Update is called once per frame
    void Update()
    {


        if (hj.jointAngle > 70)
        {
            motor.motorSpeed = -100;
            hj.motor = motor;

        }

        else if (hj.jointAngle < -70)
        {
            motor.motorSpeed = 100;
            hj.motor = motor;
        }

    }

}