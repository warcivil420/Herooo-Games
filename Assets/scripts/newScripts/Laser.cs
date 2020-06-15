using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{

	private LineRenderer lineRenderer;
	public Transform LaserHit;
	

	void Start()
	{

		lineRenderer = GetComponent<LineRenderer>();
		lineRenderer.useWorldSpace = true;
		lineRenderer.enabled = true;
	}

	void Update()
	{

		RaycastHit2D hit = Physics2D.Raycast(transform.position, transform.up);
		LaserHit.position = hit.point;
		Debug.DrawLine(transform.position, hit.point);
		lineRenderer.SetPosition(0, transform.position);
		lineRenderer.SetPosition(1, LaserHit.position);
		
	}

	
}
