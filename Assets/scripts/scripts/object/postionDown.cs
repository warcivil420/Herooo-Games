using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class postionDown : MonoBehaviour
{
   
    public bool flag1 = true;
    public GameObject rb;
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
            if (rb.transform.rotation.z == 0)
            {
                if (flag1)
                {
                    en = true;
                    rb.transform.position = new Vector3(transform.position.x-0.4f, transform.position.y + 0.4f, transform.position.z);
                    flag1 = !flag1;
                }
            }
        }
        else if(!but.forr)
        {

            flag1 = true;
            if (en)
            {
                rb.transform.position = new Vector3(transform.position.x, transform.position.y - 0.4f, transform.position.z);
                en = !en;
            }
        }
    }
    
}
