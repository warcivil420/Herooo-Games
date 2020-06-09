using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spDown : MonoBehaviour
{
 
 	public  float UpdateLim = 17f;
	public static float speed;
	public static float signal;
	public static float limitUp;

	void Start(){

		limitUp = 0f;
		signal = 0f;
	}

    void OnTriggerEnter2D(Collider2D col)
    		{
       			 if (col.gameObject.tag == "Player")
       				limitUp+=UpdateLim;
       				speed-=0.5f;
       				signal-=1f;
    		}  
}
