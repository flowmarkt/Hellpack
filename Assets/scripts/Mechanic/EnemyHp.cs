using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHp : MonoBehaviour {

	public float maxHp = 10;
	private float Hp = 5;

	// Use this for initialization
	void Start () {
		Hp = maxHp;
	}
	
	void OnTriggerEnter(Collider other)
	{
	
		if("PlayerProjectile" == other.tag)
		{
			--Hp;
			if(0 >= Hp)
			{
				Destroy(this.gameObject);
			}
		}
	}
}
