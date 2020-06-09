using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menuUi : MonoBehaviour
{

    public GameObject shop;
    public GameObject infin;
    public GameObject play;
    public GameObject puzzl;
    public int contr=0;

    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    public void infinclick()
    {
        
     
            play.SetActive(false);

    
            shop.SetActive(false);

      
            puzzl.SetActive(false);


        contr = 2;
        infin.SetActive(true);
        
    }
    public void puzzlclick()
    {
       
       
            play.SetActive(false);

            shop.SetActive(false);

        
            infin.SetActive(false);
        contr = 4;

        puzzl.SetActive(true);
      
    }
    public void shopclick()
    {
        
       
            play.SetActive(false);

      
            puzzl.SetActive(false);

       
            infin.SetActive(false);


        contr = 3;
        shop.SetActive(true);
        

    }
    public void playclick()
    {
       
  
            shop.SetActive(false);

            puzzl.SetActive(false);

       
            infin.SetActive(false);
         contr = 1;

        play.SetActive(true);
       
    }
}
