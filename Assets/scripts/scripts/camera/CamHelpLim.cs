
using UnityEngine;

public class CamHelpLim : MonoBehaviour
{

   public static float leftLimit;
   public static float rightLimit;
   public static float bottomLimit;
   public static float upperLimit;
   public GameObject[] Sector;


	void Start(){

		leftLimit = rightLimit = bottomLimit = upperLimit = 0f;
	
	}

    void OnTriggerEnter2D(Collider2D col)
    		{
       			 if ( Sector.Length < 2 &&  (col.gameObject.tag == "Player") && Vector2.Distance(transform.position, col.transform.position ) > 0.5f) 
       			 {

       			 	leftLimit = Sector[0].transform.position.x;
       			 	rightLimit = Sector[0].transform.position.x;
       			 	bottomLimit = Sector[0].transform.position.y;
       			 	upperLimit = Sector[0].transform.position.y;
       			 }
       			 else
       			 	if (  Sector.Length == 2 &&  (col.gameObject.tag == "Player") && Vector2.Distance(transform.position, col.transform.position ) > 0.5f  )
       			 	{
       			 		
       			 	leftLimit =   Sector[0].transform.position.x;
       			 	rightLimit =  Sector[1].transform.position.x;
       			 	bottomLimit = Sector[0].transform.position.y;
       			 	upperLimit =  Sector[0].transform.position.y;

       			 	}
       				 else
       			 	if (  Sector.Length == 3 &&  (col.gameObject.tag == "Player") && Vector2.Distance(transform.position, col.transform.position ) > 0.5f  )
       			 	{
       			 	
       			 			Debug.Log(Sector[1].transform.position.x);
       			 			Debug.Log(Sector[2].transform.position.x);
       			 	leftLimit =   Sector[0].transform.position.x;
       			 	rightLimit =  Sector[0].transform.position.x;
       			 	bottomLimit = Sector[2].transform.position.y;
       			 	upperLimit =  Sector[1].transform.position.y;

       			 	}

    		}                  
 }
