using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptPan : MonoBehaviour
{
   [SerializeField]
   	GameObject Panel;
   
   	void Start(){
   		Panel.SetActive(false);
   	}

   	void OnTriggerEnter2D(Collider2D col)
   	{

   		if (col.tag == "Player")
   		{

   			Panel.SetActive(true);
   			Time.timeScale = 0.1f*Time.deltaTime;

   		}

   	}


}
