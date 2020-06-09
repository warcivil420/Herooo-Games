using UnityEngine;

public class triggerscript : MonoBehaviour
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
        	trg.enabled = false;
        	colorUp.color = new Color(1f, 0f, 0.9577489f, 0.2f);
    	}
    	else 
    	{
            trg.enabled = true;
    		colorUp.color = new Color(1f, 0f, 0.9577489f, 1f);
    	}
}
}
