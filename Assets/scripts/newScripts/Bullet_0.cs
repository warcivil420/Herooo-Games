using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_0 : MonoBehaviour
{
    public float speed = 1f;

    public KeyCode destrButt = KeyCode.M;
	public static bool flag = true;
   
    public Rigidbody2D rb;
    
    public static Vector3 flagPos;
   
    void FixedUpdate()
    {
    	

    	rb.velocity = transform.right*speed;
    	transform.rotation = Quaternion.Euler(0, 0, portal.Poz); 
        
        flagPos = rb.transform.position;
    	
        if (Input.GetKey(destrButt))
        {
        if(portal.flagBullet)
        {
         portal.flagBullet = false;
         CamHelpLim.leftLimit   = CamHelpLim.Limit[0];
         CamHelpLim.rightLimit  = CamHelpLim.Limit[1];
         CamHelpLim.upperLimit  = CamHelpLim.Limit[2];
         CamHelpLim.bottomLimit = CamHelpLim.Limit[3];
 		}
         PlayerControllerChar.isFire = true;
         PlayerControllerChar.isTp = true;
         Destroy(this.gameObject);
        }

    }

 

    /*
    void Rot(){
    	transform.rotation = Quaternion.Euler(0, 0, -90); 
    }
	*/
}
