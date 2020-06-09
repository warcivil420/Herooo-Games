using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pitch : MonoBehaviour
{
    public AudioSource s;
    void Update()
    {
        s = GetComponent<AudioSource>();
        if (but.forr)
        {

            s.pitch = 0.5f;
        }
        else if (!but.forr) s.pitch = 1f;
    }

}
