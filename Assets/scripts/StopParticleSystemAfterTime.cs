using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopParticleSystemAfterTime : MonoBehaviour {

	public float time = 0.1f;

	// Use this for initialization
	void Start () {
		StartCoroutine("StopRoutine");
	}
	
	IEnumerator StopRoutine()
	{
		yield return new WaitForSeconds(time);
		gameObject.GetComponent<ParticleSystem>().Stop();
		//Destroy(this);
	}
}
