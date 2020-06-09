using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class but : MonoBehaviour
{
    public  GameObject Panel1;
    public static bool forr=false;
    Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }
    void Update()
    {

        if (death.nodead){
            Panel1.SetActive(false);
            forr = false;
        }
        if (forr) Time.timeScale = 0.5f;
         else Time.timeScale = 1f;

    }
    public void Helix()
    {

       
        if (forr) forr = false;
        else forr = true;
      
        

    }

    
    void stoping()
    {
        
    }




}
