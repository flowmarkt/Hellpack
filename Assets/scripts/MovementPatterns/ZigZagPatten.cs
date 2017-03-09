using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZigZagPatten : MonoBehaviour {

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
			if(0 == (counter%2))
			{
				targetPosition = new Vector3(-2,2,5	);
			}
			else
			{
				targetPosition = new Vector3(2,2,5	);
			}
			++counter;
		}
	}
}
