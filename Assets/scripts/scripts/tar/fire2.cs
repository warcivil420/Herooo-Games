using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fire2 : MonoBehaviour
{
    public float mn = 1f;
    public bool gr = true;
    public Transform firePoint;
    public GameObject bullet;
    // Update is called once per frame
    void Update()
    {
    
        
            if (gr) shoot();

            mn -= Time.deltaTime;

            if (mn < 0) gr = true;

        
    }
    void shoot()
    {
        Instantiate(bullet, firePoint.position, firePoint.rotation);
        gr = false;
        mn = 1f;
    }
}
