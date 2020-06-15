using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class portal : MonoBehaviour
{
	public GameObject NextPortal;
   	

   	public static bool flagBullet=false;
   	public static float Poz;



	void OnTriggerEnter2D(Collider2D paun)
	{
		if (Vector2.Distance(transform.position, paun.transform.position ) > 0.5f)
			{
			paun.transform.position = NextPortal.transform.position; 
			}

		else ;

		if ((paun.tag == "Bullet") && (Bullet_0.flag))
		{
			Poz = NextPortal.transform.localEulerAngles.z;
			Bullet_0.flag = !Bullet_0.flag;
			flagBullet = true;
		}

		else 
			if ((paun.tag == "Bullet") && (!Bullet_0.flag))
			{
				Bullet_0.flag = !Bullet_0.flag;
			}

	}
}
