using UnityEngine;

public class triggerDown : MonoBehaviour
{
	public SpriteRenderer colorUp;
 	public EdgeCollider2D trg;
    void Start()
    {
    	colorUp = GetComponent<SpriteRenderer>();
        trg = GetComponent<EdgeCollider2D>();
    }

   
    void Update()
    {
        if(but.forr)
        { 
        	trg.isTrigger = false;
        	colorUp.color = new Color(0f, 1, 0.9731088f, 1f);
    	}
    	else
    	{
    		trg.isTrigger = true;
    		colorUp.color = new Color(0f, 1, 0.9731088f, 0.2f);
    	}
}
}
