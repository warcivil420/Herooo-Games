using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class echoEffect : MonoBehaviour
{
    public float timeBtwnSpawns;
    public float startTimeBtwSpawns;
    public GameObject echo;

    void Update()
    {
        if (but.forr)
        {
            if (timeBtwnSpawns <= 0)
            {
              
                GameObject instance = (GameObject)Instantiate(echo, transform.position, Quaternion.identity);
                Destroy(instance, 0.5f);
                timeBtwnSpawns = startTimeBtwSpawns;
            }
            else
            {
                timeBtwnSpawns -= Time.deltaTime;
            }
        }
    }
}
