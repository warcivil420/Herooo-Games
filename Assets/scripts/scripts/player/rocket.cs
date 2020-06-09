using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rocket : MonoBehaviour
{
    Animator anim;
    public GameObject effectPrefab;
    public Rigidbody2D rb;
    public float jumpForce = 3f;
    public float speed = 2.45f;
    public bool jumping = false;
    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void Update()
    {
        if (death.nodead)
        {
            Destroy(gameObject);
        }
    }
    void FixedUpdate()
    {
        rb.velocity = new Vector2(speed, rb.velocity.y);
        if (jumping)
        {
            rb.transform.rotation = Quaternion.Euler(0, 0, -5f);
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
            jumping = false;
            Invoke("ter", 0.3f);
        }
    }
    public void ter()
    {
        rb.transform.rotation = Quaternion.Euler(0, 0, 0);
    }
    public void prejump()
    {
        jumping = true;
    }
    public void effect()
    {
        Instantiate(effectPrefab, transform.position, Quaternion.Euler(0, 0, 0));
    }
}
