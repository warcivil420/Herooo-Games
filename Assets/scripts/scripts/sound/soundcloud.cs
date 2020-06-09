using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundcloud : MonoBehaviour
{
    public AudioSource myFx;
 
    public AudioClip clam;
    void Start()
    {
        myFx.Stop();
    }
     void Update()
    {
        if ((death.nodead)|| (Enem.pull))
        {
            myFx.PlayOneShot(clam);
            death.nodead = false;
            Enem.pull = false;
            
        }
    }
}
