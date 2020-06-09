using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class big : MonoBehaviour
{
    public GameObject rt;
    public float h = 0.08f;
    public float h1 = 0.13f;
    // Update is called once per frame
    void FixedUpdate()
    {
   
        if(but.forr)
            rt.transform.localScale = new Vector3(h, h, h);
        else
        {
            rt.transform.localScale = new Vector3(h1, h1, 1.0f);
        }
    }
}
