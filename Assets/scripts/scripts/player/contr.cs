using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class contr : MonoBehaviour
{
    public GameObject effectPrefab;
    void Update()
    {
        if (death.hel)
        {
            Instantiate(effectPrefab, transform.position, Quaternion.Euler(0, 0, 0));
            Destroy(gameObject);
            death.hel = false;
           
        }
    }

}
