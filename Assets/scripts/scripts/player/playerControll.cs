using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControll : MonoBehaviour
{
    private Animator anim;
    public bool inAir = true;
    public float horizontalSpeed;
    float speedX;
    public float jump1 = 183f;
    public float VerticalImpulse;
    public Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    public void jump()
    {
        if (!inAir)
        {
            inAir = true;
            // anim.SetInteger("numb", 3);

            rb.AddForce(new Vector2(0, VerticalImpulse), ForceMode2D.Impulse);

        }
    }



    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.S))
            Time.timeScale = 0.4f;


        if (Input.GetKey(KeyCode.A))
        {
            anim.SetBool("isRunning", true);
            speedX = -horizontalSpeed;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            anim.SetBool("isRunning", true);
            speedX = horizontalSpeed;
        }

        else anim.SetBool("isRunning", false);

        if (Input.GetKeyDown(KeyCode.Space) && !inAir)       // прыжок персонажа
        {
            anim.SetBool("isJumping", true);
            jump();

        }
        else
        {
            if (inAir == false)
                anim.SetBool("isJumping", false);
        }
        transform.Translate(speedX, 0, 0);
        speedX = 0;

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.layer == LayerMask.NameToLayer("ground"))          // проверка перед прыжком
        {
            inAir = false;

        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Default"))          // проверка перед прыжком
        {
            inAir = true;
            anim.SetBool("isJumping", true);
        }

    }
}