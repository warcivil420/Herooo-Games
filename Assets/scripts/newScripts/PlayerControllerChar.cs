﻿using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody2D))]

public class PlayerControllerChar : MonoBehaviour {

	Animator anim;


	public enum ProjectAxis {onlyX = 0, xAndY = 1};
	public ProjectAxis projectAxis = ProjectAxis.onlyX;
	
	public bool lookAtCursor;
	private bool jump;
	public static bool isFacingRight = true;
	public static bool isFire = true;
	public static bool isTp = false;


	public KeyCode leftButton = KeyCode.A;
	public KeyCode rightButton = KeyCode.D;
	public KeyCode addForceButton = KeyCode.Space;
	public KeyCode FireButton = KeyCode.G;
	public KeyCode E = KeyCode.E;
	
	private Vector3 direction;

	public float speed = 100;
	public float addForce = 5;
	private float vertical;
	private float horizontal;
	private float rotationY;

	private Rigidbody2D body;



    

    

	void Start () 
	{
		anim = GetComponent<Animator>();
		body = GetComponent<Rigidbody2D>();
		body.fixedAngle = true;

		if(projectAxis == ProjectAxis.xAndY) 
		{
			body.gravityScale = 0;
			body.drag = 10;
		}
	}

	void OnCollisionStay2D(Collision2D coll) 
	{
		if(coll.transform.tag == "Ground")
		{
			body.drag = 10;
			jump = true;
		}
	}
	
	void OnCollisionExit2D(Collision2D coll) 
	{
		if(coll.transform.tag == "Ground")
		{
			body.drag = 0;
			jump = false;
		}
	}
	
	void FixedUpdate()
	{
		
		body.AddForce(direction * body.mass * speed);

		if(Mathf.Abs(body.velocity.x) > speed/100f)
		{
			body.velocity = new Vector2(Mathf.Sign(body.velocity.x) * speed/100f, body.velocity.y);
		}

		if(projectAxis == ProjectAxis.xAndY)
		{
			if(Mathf.Abs(body.velocity.y) > speed/100f)
			{
				body.velocity = new Vector2(body.velocity.x, Mathf.Sign(body.velocity.y) * speed/100f);
			}
		}
		else
		{
			if(Input.GetKey(addForceButton) && jump)
			{
				body.velocity = new Vector2(0, addForce);
			}
		}
	}

	void Flip()
	{
		if(projectAxis == ProjectAxis.onlyX)
		{
			isFacingRight = !isFacingRight;
			Vector3 theScale = transform.localScale;
			theScale.x *= -1;
			transform.localScale = theScale;
		}
	}
	
	void Update () 
	{



		if(Input.GetKey(leftButton)) 
		{
			anim.SetBool("isStep", true);
			horizontal = -1;
		}
		else if(Input.GetKey(rightButton))
		{
		 anim.SetBool("isStep", true);		
		 horizontal = 1; 
		}

		else
		{
		 anim.SetBool("isStep", false);
		 horizontal = 0;
		}

	
		if(projectAxis == ProjectAxis.onlyX) 
		{
			direction = new Vector2(horizontal, 0); 
		}
		else 
		{
			if(Input.GetKeyDown(addForceButton)) 
			{
				speed += addForce;
			}

			else if(Input.GetKeyUp(addForceButton))
			{
			    speed -= addForce;
			}

			direction = new Vector2(horizontal, vertical);
		}

		if(horizontal > 0 && !isFacingRight) Flip(); else if(horizontal < 0 && isFacingRight) Flip();

		if(isTp)
		{
		isTp = false;
		body.transform.position = Bullet_0.flagPos;
		}

	}

/*

	public void MobileControllerLeft()
	{
		horizontal = -1;
	}

	public void MobileControllerRight()
	{
		horizontal = 1;
	}

	public void MobileControllerStop()
	{
		horizontal = 0;
	}

	 public void Jump()
    {
        body.AddForce(transform.up * addForce, ForceMode2D.Impulse);
    }
    */



}