using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class portal : MonoBehaviour
{
	public GameObject NextPortal;
   
	void OnTriggerEnter2D(Collider2D paun){
		if (Vector2.Distance(transform.position, paun.transform.position ) > 0.5f)
			{
			paun.transform.position = NextPortal.transform.position; 
			}
	}


}
