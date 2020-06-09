using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class txtlvl3att : MonoBehaviour
{
   System.Random rand = new System.Random();
   public Text st1;
   public static int k;

    void Start()
    {
        k = rand.Next(0, textManager.mas.Length - 1);
        st1 = GetComponent<Text>();
    }


     void Update()
    {
        st1.text = textManager.mas[k];
    }
}