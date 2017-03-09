using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleBehaviour : MonoBehaviour {

	//destroy collectible
	//Score.IncrementScore();
	void OnTriggerEnter(Collider other)
	{
		if("Player" == other.tag)
		{
			Score.IncrementScore();
			Destroy(gameObject);
		}
	}
}
