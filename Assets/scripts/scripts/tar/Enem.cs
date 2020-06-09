using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enem : MonoBehaviour
{
    public static bool pull = false;
    public static bool myFx = false;
    public GameObject effectPrefab;
    public static bool dt = false;
    public static int health=1;
    public void Damage(int damage)
    {
        health -= damage;
        if ((health == 0))
        {
            Instantiate(effectPrefab, transform.position, Quaternion.Euler(0, 0, 0));
            Destroy(gameObject);
            myFx = true;
            dt = true;
            pull = true;
        }
    }
    
}
