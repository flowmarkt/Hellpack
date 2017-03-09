using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFire : MonoBehaviour {
	
	[Range(1,20)]
	public float impuls;
	[Range(0,5)]
	public float offset;
	[Range(1,3)]
	public float period;

	private GameObject projectile;

	// Use this for initialization
	void Start () {
		projectile = Resources.Load<GameObject>("Prefabs/EnemyProjectile");
        StartCoroutine("FireRoutine");
	}
	
	// Update is called once per frame
	void Update () {	
		
	}
	
	IEnumerator FireRoutine()
	{
		while(true)
		{
			yield return new WaitForSeconds(period-offset);
			GameObject newProjectile = Instantiate(projectile,transform.position,projectile.transform.rotation);
			newProjectile.GetComponent<Rigidbody>().AddForce(Vector3.back*impuls,ForceMode.Impulse);
			Destroy(newProjectile,10f);
			yield return new WaitForSeconds(offset);
		}
	}
}
