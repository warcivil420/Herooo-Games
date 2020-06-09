using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class positinUp : MonoBehaviour
{
    public GameObject rb;
    public bool flag = true;
    public bool en = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (but.forr)
        {

            if (flag)
            {
                rb.transform.position = new Vector3(transform.position.x+0.4f, transform.position.y - 0.4f, transform.position.z);
                flag = !flag;
                en = true;



            }

        }
        else if (!but.forr)
        {
            if (en)
            {
                rb.transform.position = new Vector3(transform.position.x, transform.position.y + 0.4f, transform.position.z);
                en = !en;
            }
            flag = true;
        }

    }
}
