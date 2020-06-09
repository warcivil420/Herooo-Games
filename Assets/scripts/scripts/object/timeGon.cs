using UnityEngine;

public class timeGon : MonoBehaviour
{
    public float spd = 222;

    public HingeJoint2D tr;
    public float timee;
    public void Update()
    {
    	
        JointMotor2D motor = tr.motor;
        //   tr = GetComponent<HingeJoint2D>();
        if (but.forr)
        {
           
            motor.motorSpeed = 10;
            tr.motor = motor;
        }
        else
        {
            
            motor.motorSpeed = spd;
            tr.motor = motor;
        }
    }
}
