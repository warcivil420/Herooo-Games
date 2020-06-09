using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class speed : MonoBehaviour
{
    public static float timeUpdate = 0.0f;
    public static int timer = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(txt.hour1 == timer)
        {
            timer++;
            timeUpdate = 0.1f;
        }
    }
}
