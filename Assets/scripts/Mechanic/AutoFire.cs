using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoFire : MonoBehaviour {

	[Range(10,30)]
	public float impuls;
	[Range(0,1)]
	public float period;

	private GameObject projectile;
	
	// Use this for initialization
	void Start () {
		projectile = Resources.Load<GameObject>("Prefabs/PlayerProjectile");
        StartCoroutine("FireRoutine");
	}
	
	RaycastHit hit;
	
	IEnumerator FireRoutine()
	{
		while(true)
		{
			yield return new WaitForSeconds(period);
			if (Physics.Raycast(transform.position, Vector3.forward,out hit, 12) &&
					("Enemy" == hit.collider.tag))
			{
				GameObject newProjectile = Instantiate(projectile,transform.position,projectile.transform.rotation);
				newProjectile.GetComponent<Rigidbody>().AddForce(Vector3.forward*impuls,ForceMode.Impulse);
				Destroy(newProjectile,5f);
			}
		}
	}
}
