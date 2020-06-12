using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_0 : MonoBehaviour
{

	public GameObject Bullet;


	public static bool flag = true;
    public float speed = 1f;
    public Rigidbody2D rb;
    void FixedUpdate()
    {
    	
    	rb.velocity = transform.right*speed;
    	transform.rotation = Quaternion.Euler(0, 0, portal.Poz); 
    	//Invoke("Rot", 2f);

    }
    /*
    void Rot(){
    	transform.rotation = Quaternion.Euler(0, 0, -90); 
    }
	*/
}
