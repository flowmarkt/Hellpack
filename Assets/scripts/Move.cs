using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

	static float speed = 8;

	// Use this for initialization
	void Start () {
		gameObject.GetComponent<Rigidbody>().AddForce(Vector3.back*speed,ForceMode.VelocityChange);
	}
	
	public float GetSpeed()
	{
		return speed;
	}
}
