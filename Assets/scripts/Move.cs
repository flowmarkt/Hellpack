using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {



	// Use this for initialization
	void Start () {
		gameObject.GetComponent<Rigidbody>().AddForce(Vector3.back * Constants.Speed,ForceMode.VelocityChange);
	}
	
	
}
