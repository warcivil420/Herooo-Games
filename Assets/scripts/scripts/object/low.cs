using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class low : MonoBehaviour
{
    public HingeJoint2D tr;
    public float timee;
    public void Update()
    {
        JointMotor2D motor = tr.motor;
        //   tr = GetComponent<HingeJoint2D>();
        if (but.forr)
        {

            motor.motorSpeed = -350;
            
        }
        else
        {

            motor.motorSpeed = 5;
            tr.motor = motor;

        }
        tr.motor = motor;
    }
}
