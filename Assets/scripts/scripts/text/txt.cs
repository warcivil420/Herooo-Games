using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class txt : MonoBehaviour
{
    public float speedPrc=1f;
    private Text Coin;
    public int hour;
    public static int hour1;
    public int sec;
    public int sec1;
    public int timer = 1;

    void Start()
    {
  
        Coin = GetComponent<Text>();
        Invoke("Timer", speedPrc);
    }

    public void Timer()
    {
        if (but.forr)
            speedPrc = 0.4f;
        else
            speedPrc = 1f;
        
        sec1++;
        if (sec1 == 10)
        {
            sec1 = 0;
            sec++;
            if (sec == 6)
            {
                sec = 0;
                hour1++;
                if (hour1 == 10)
                {
                    hour1 = 0;
                    hour++;
                }
            }
        }
        Timer1();
    }

    public void Timer1()
    {
        if (hour1 == timer)
        {
            timer++;
            Coin.text = "speed up";
            Invoke("gon", 1f);
        }
        else
            gon();

        Invoke("Timer", speedPrc);

    }
    public void gon()
    {
        Coin.text = hour + hour1 + ":" + sec + sec1;
    }
}