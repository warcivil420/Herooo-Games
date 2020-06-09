using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class strelDestr : MonoBehaviour
{
	private Animator anim;

	void Start(){
		anim = GetComponent<Animator>();
	}
       
    void Destroy1() {
    	Destroy(gameObject);
    }   
    
    void OnTriggerEnter2D(Collider2D col)
    		{
       			 if (col.gameObject.tag == "Player")
       				anim.SetBool("activate", true);
       				Invoke("Destroy1", 1f);
    		}         
}
	
