using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disavlerZM : MonoBehaviour
{
	public GameObject zmPanel;
    // Start is called before the first frame update
    void Start()
    {
        zmPanel.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if(death.nodead) zmPanel.SetActive(false);
    }
}
