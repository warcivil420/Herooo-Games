using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirePoint : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bullet;

    void Start()
    {
    	Invoke("Shoot", 1f);    
    }

    void Shoot()
    {
    	Instantiate(bullet, firePoint.position, firePoint.rotation);	
    	
    }




}
