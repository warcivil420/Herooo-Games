﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 10f;
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * speed;
    }
    private void OnTriggerEnter2D(Collider2D hitinfo)
    {
        Destroy(gameObject);
        Enem enem = hitinfo.GetComponent<Enem>();
        if (enem != null) ;
        {
            enem.Damage(1);
        } 
        
        
    }
  
}
