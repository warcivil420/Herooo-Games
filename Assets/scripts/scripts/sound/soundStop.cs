using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundStop : MonoBehaviour
{
    public AudioSource myFx;


    // Update is called once per frame
    void Update()
    {
        if ((Enem.myFx)||(death.MyFx))
        {
            myFx.Stop();
            death.MyFx = false;
            Enem.myFx = false;
        }
    }
}
