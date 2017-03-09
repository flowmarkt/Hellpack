using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XPattern : MonoBehaviour {

	private Vector3 targetPosition;
	
	[Range(1,5)]
	public float period;
	[Range(0,5)]
	public float offset;
	[Range(1,50)]
	public float speed;
	
	private int counter = 0;
	
	// Use this for initialization
	void Start () {
		StartCoroutine("PatternRoutine");
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
			yield return new WaitForSeconds(period);
			switch(counter%4)
			{
				case 0: 	
					targetPosition = new Vector3(-2,2,5	);
					break;
				case 2: 
					targetPosition = new Vector3(2,2,5);
					break;
				case 1: 
					targetPosition = new Vector3(2,-2,5);
					break;
				case 3: 
					targetPosition = new Vector3(-2,-2,5);
					break;
				default: 
					targetPosition = new Vector3(-2,2,5);
					break;
			}
			++counter;
		}
	}
}
