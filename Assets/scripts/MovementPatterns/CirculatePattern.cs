using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CirculatePattern : MonoBehaviour {

	private Vector3 targetPosition;
	
	[Range(1,5)]
	public float period;
	[Range(0,5)]
	public float offset;
	[Range(1,50)]
	public float speed;
	
	private int counter = 0;
	private float initialZ = 0;
	
	// Use this for initialization
	void Start () {
		StartCoroutine("PatternRoutine");
		initialZ = transform.position.z;
	}
	
	void Update()
	{
		
		float distance = (targetPosition - transform.position).magnitude;

        transform.position = Vector3.Lerp(transform.position, targetPosition, Time.deltaTime * distance * speed);
	}
	
	IEnumerator PatternRoutine()
	{
		while(true)
		{
			yield return new WaitForSeconds(period-offset);
			switch(counter%4)
			{
				case 0: 	
					targetPosition = new Vector3(-2,2,initialZ);
					break;
				case 1: 
					targetPosition = new Vector3(2,2,initialZ);
					break;
				case 2: 
					targetPosition = new Vector3(2,-2,initialZ);
					break;
				case 3: 
					targetPosition = new Vector3(-2,-2,initialZ);
					break;
				default: 
					targetPosition = new Vector3(-2,2,initialZ);
					break;
			}
			++counter;
			yield return new WaitForSeconds(offset);
		}
	}
	
}
