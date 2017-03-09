using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleController : MonoBehaviour {

	private Vector3 targetPosition;
	
	private GameObject vehicle;
	
	[Range(1,50)]
	public float speed;
	
	void Start()
	{
		vehicle = GameObject.Find("Vehicle");
	}
	
	public void EnterUpperLeft()
	{
		targetPosition = new Vector3(-2,2,0);
	}
	public void EnterUpperRight()
	{
		targetPosition = new Vector3(2,2,0);
	}
	public void EnterLowerLeft()
	{
		targetPosition = new Vector3(-2,-2,0);
	}
	public void EnterLowerRight()
	{
		targetPosition = new Vector3(2,-2,0);
	}
	
	void Update()
	{
		
		float distance = (targetPosition - vehicle.transform.position).magnitude;

        vehicle.transform.position = Vector3.Lerp(vehicle.transform.position, targetPosition, Time.deltaTime * distance * speed);
	}
}
