using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disabler : MonoBehaviour
{
	public GameObject dis;
    void Start()
    {
        
    }


    void Update()
    {
        
    }

      private void OnTriggerEnter2D(Collider2D player)
    {
        if(player.gameObject.tag == "Player") dis.SetActive(false);
        
        
    }

}
