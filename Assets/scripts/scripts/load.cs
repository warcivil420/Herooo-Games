using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class load : MonoBehaviour
{
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
   public void Update()
    {
        if (death.alive)
        {
            death.alive = false;   
            Time.timeScale = 1f;
            SceneManager.LoadScene(menuscene.f);
        }    
    }
   
  
}
