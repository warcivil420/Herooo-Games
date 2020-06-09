using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activat : MonoBehaviour
{
    public GameObject effectPrefab;


    void OnCollisionEnter2D(Collision2D st)
    {
        if (st.gameObject.tag == "Player")
        {
            Instantiate(effectPrefab, transform.position, Quaternion.Euler(0, 0, 0));
        }
    }
}
