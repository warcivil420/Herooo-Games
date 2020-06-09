using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destruct : MonoBehaviour
{

	public GameObject effect;
    void Update()
    {
        Invoke("destruct1", 1.2f);
    }

    void destruct1(){
    	Destroy(effect);
    }
}
