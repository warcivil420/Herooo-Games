using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class remoter : MonoBehaviour
{
    public HingeJoint2D tr;
    public void Update()
    {
        JointMotor2D motor = tr.motor;
        //   tr = GetComponent<HingeJoint2D>();
        if (but.forr)
        {

            motor.motorSpeed = -180;
            
        }
        else
        {

            motor.motorSpeed = 200;
            tr.motor = motor;

        }
        tr.motor = motor;
    }
}
