using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dviz : MonoBehaviour
{
    public Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.velocity = new Vector2(0.2f, rb.velocity.y);

    }
}
