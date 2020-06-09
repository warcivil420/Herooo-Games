using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class death : MonoBehaviour
{
    public static bool helpCanal = false;
    public static bool MyFx = false;
    public static bool hel = false;
    public static bool alive=false;
    public GameObject effectPrefab;
    public static bool nodead=false;
    // Start is called before the first frame update
    void Start()
    {
        helpCanal = false;
        nodead = false;  
    }

    // Update is called once per frame
    void Update()
    {
        if (Enem.dt)
        {
            but.forr = false;
            Invoke("Reloadlvl", 0.8f);

        }
    }

    void Reloadlvl()
    {

        alive = true;
        Enem.health = 1;
        Enem.dt = false;
        
    }

    void OnCollisionEnter2D(Collision2D st)
    {
        if (st.gameObject.tag == "Player")
        {
               helpCanal = true;
                MyFx = true;
                Instantiate(effectPrefab, transform.position, Quaternion.Euler(0, 0, 0));
                but.forr = false;
                nodead = true;
                hel = true;
                Invoke("Reloadlvl", 1.13f);
                    
        }
    }
   
}
