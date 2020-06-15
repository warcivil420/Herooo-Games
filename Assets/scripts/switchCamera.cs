using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;


public class switchCamera : MonoBehaviour
{	public Transform focusCam;
  public Transform Player;
  private Vector3 pozPlay;
  public Camera cam;
    void Start()
		{

			cam = Camera.main;
		}

        void Update () 
        {		

          pozPlay =  new Vector3(Player.position.x, Player.position.y, -10);
           if(Input.GetKeyDown("c"))
      		{
          GetComponent<camcontroller>().enabled = false;
         
   	    	﻿﻿﻿﻿﻿transform.DOMove(focusCam.position, 1);
  			  cam.DOOrthoSize(9f, 1);
         
  			}
     	
  		 if (Input.GetKeyUp("c"))
  		   {
          GetComponent<camcontroller>().enabled = true;
         
  		 	transform.DOMove(new Vector3(CamHelpLim.leftLimit, CamHelpLim.upperLimit, -10f), 1);
  		 	cam.DOOrthoSize(2f, 1);
  		   }    
 		
		}


public void MobileButUp()
{

     GetComponent<camcontroller>().enabled = false;
     ﻿﻿﻿﻿﻿transform.DOMove(focusCam.position, 1);
     cam.DOOrthoSize(9f, 1);

}
		
public void MobileButDown()
{

    GetComponent<camcontroller>().enabled = true;
    transform.DOMove(new Vector3(CamHelpLim.leftLimit, CamHelpLim.upperLimit, -10f), 1);
    cam.DOOrthoSize(2f, 1);

}
    

}