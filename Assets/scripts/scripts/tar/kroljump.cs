using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kroljump : MonoBehaviour
{
    public Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (but.forr)
        {
            rb.velocity = new Vector2(rb.velocity.x, 0);
        }
    }

    void OnCollisionEnter2D(Collision2D st)
    {
        if (st.gameObject.tag == "ground")
        {
            rb.velocity = new Vector2(rb.velocity.x, 5f);

        }
    }
}
