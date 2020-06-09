using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class coin : MonoBehaviour
{
   public static int sumCoin;
    private Text ссoin;
    // Start is called before the first frame update
    void Start()
    {
        sumCoin = 0;
        ссoin = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        ссoin.text = "x" + " " + sumCoin;
    }
}
