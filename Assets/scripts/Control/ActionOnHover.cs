using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ActionOnHover : MonoBehaviour {

	public UnityEvent EnterSegment;
	
	
	void OnMouseEnter()
	{
		EnterSegment.Invoke();
	}
	
	
}
