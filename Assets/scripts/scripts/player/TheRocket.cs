using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheRocket : MonoBehaviour
{
    public bool active = false;
    public Rigidbody2D rb;
     float x = 100;
    float dump = 0;
    float dump1 = 0;

    public float speed = 2.45f;
    private float _speed;

    void Start()
    {
      
        rb = GetComponent<Rigidbody2D>();
    }
   public void FixedUpdate()
    {
        
        if (active)
        {
            Invoke("elp", 0.1f);

            dump += 0.25f;
           
        }
       else if(!active)
        {
            Invoke("antielp", 0.1f);
            dump -= 0.2f;
        
        }
    }
    // Mathf.MoveTowards(x, 2, 0.1)

    public void actiive() {
        active = true;
    
    }
    public void passive()
    {
        active = false;
    }


    public void elp()
    {
        rb.velocity = new Vector2(speed, dump);
    //    rb.transform.rotation = Quaternion.Euler(0, 0, dump1);
    }
    public void antielp()
    {
        rb.velocity = new Vector2(speed, dump);
    //    rb.transform.rotation = Quaternion.Euler(0, 0, dump1);
    }
}
