using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stages : MonoBehaviour {

	private GameObject enemy;
	private GameObject collectible;
	private GameObject obstacle;
	private bool waveGenerationOngoing = false;
	private int waveNumber = 0;
	public Text waveTxt;

	// Use this for initialization
	void Start () {
		enemy = Resources.Load<GameObject>("Prefabs/Enemy");
		collectible = Resources.Load<GameObject>("Prefabs/Collectible");
		obstacle = Resources.Load<GameObject>("Prefabs/Obstacle");
	}
	
	// Update is called once per frame
	void Update () {
		
		
		
		//TODO ha nem talál enemyt és véget ért a wave akkor új wave 
		if((false == waveGenerationOngoing)&&
				(10 > waveNumber)&&
					(null == GameObject.Find("Enemy(Clone)"))&&
						(null == GameObject.Find("Collectible(Clone)"))&&
							(null == GameObject.Find("Obstacle(Clone)")))					//TODO: esetleg egy tömbből tolni az ellenségeket
			{
				
				StartCoroutine("WaveText");
				
				switch(waveNumber)									//TODO: egy tömbbe belerakni a függvényeket? UnityEvent tömb?
				{
					case 0: 
						StartCoroutine("CollectibleWave1");
						break;
					case 1: 
						//StartCoroutine("Stage1");
						break;
					case 2: 
						StartCoroutine("CollectibleWave3");
						break;
					case 3: 
						//StartCoroutine("Stage2");
						break;
					case 4: 
						StartCoroutine("CollectibleWave2");
						break;
					case 5: 
						StartCoroutine("CollectibleWave4");
						break;
					case 6: 
						//StartCoroutine("Stage3");
						StartCoroutine("CollectibleWave3");
						break;
					case 7: 
						//StartCoroutine("Stage4");
						StartCoroutine("CollectibleWave4");
						break;
					case 8: 
						StartCoroutine("CollectibleWave5");
						break;
					case 9: 
						StartCoroutine("CollectibleWave6");
						break;
					default:
						
						break;
				}
				++waveNumber;
			}
		
		if(Input.GetKeyDown(KeyCode.Keypad1))
		{
			StartCoroutine("Stage1");
		}
		else if(Input.GetKeyDown(KeyCode.Keypad2))
		{
			StartCoroutine("Stage2");
		}
		else if(Input.GetKeyDown(KeyCode.Keypad3))
		{
			StartCoroutine("Stage3");
		}
		else if(Input.GetKeyDown(KeyCode.Keypad4))
		{
			StartCoroutine("Stage4");
		}
	}
	
	IEnumerator Stage1()
	{
		//FRAME
		waveGenerationOngoing = true;
		
		
		
		GameObject newObject;
		
		newObject = Instantiate(enemy,new Vector3(2,2,5),Quaternion.identity);
		newObject.GetComponent<CirculatePattern>().period = 3.5f;
		newObject.GetComponent<CirculatePattern>().offset = 0f;
		newObject.GetComponent<EnemyFire>().period = 3.5f;
		newObject.GetComponent<EnemyFire>().offset = 0f;
		
		newObject = Instantiate(enemy,new Vector3(-2,2,5),Quaternion.identity);
		newObject.GetComponent<CirculatePattern>().period = 3.5f;
		newObject.GetComponent<CirculatePattern>().offset = 3.5f;
		newObject.GetComponent<EnemyFire>().period = 3.5f;
		newObject.GetComponent<EnemyFire>().offset = 3.5f;
		
		yield return new WaitForSeconds(1);
	
		//FRAME
		
		waveGenerationOngoing = false;
	}
	
	IEnumerator Stage2()
	{
		waveGenerationOngoing = true;
		
		GameObject newObject;
		
		newObject = Instantiate(enemy,new Vector3(2,2,5),Quaternion.identity);
		newObject.GetComponent<CirculatePattern>().period = 3.5f;
		newObject.GetComponent<CirculatePattern>().offset = 0f;
		newObject.GetComponent<EnemyFire>().period = 3.5f;
		newObject.GetComponent<EnemyFire>().offset = 0f;
		
		yield return new WaitForSeconds(1);
		
		waveGenerationOngoing = false;
	}
	
	IEnumerator Stage3()
	{
		waveGenerationOngoing = true;
		
		GameObject newObject;
		
		newObject = Instantiate(enemy,new Vector3(2,2,5),Quaternion.identity);
		newObject.GetComponent<CirculatePattern>().period = 3.5f;
		newObject.GetComponent<CirculatePattern>().offset = 0f;
		newObject.GetComponent<EnemyFire>().period = 3.5f;
		newObject.GetComponent<EnemyFire>().offset = 0f;
		
		yield return new WaitForSeconds(1);
		
		waveGenerationOngoing = false;
	}
	
	IEnumerator Stage4()
	{
		waveGenerationOngoing = true;
		
		GameObject newObject;
		
		newObject = Instantiate(enemy,new Vector3(2,2,5),Quaternion.identity);
		newObject.GetComponent<CirculatePattern>().period = 3.5f;
		newObject.GetComponent<CirculatePattern>().offset = 0f;
		newObject.GetComponent<EnemyFire>().period = 3.5f;
		newObject.GetComponent<EnemyFire>().offset = 0f;
		
		yield return new WaitForSeconds(1);
		
		waveGenerationOngoing = false;
	}
	
	IEnumerator WaveText()
	{
		waveTxt.text = "Wave " + (waveNumber+1);
		yield return new WaitForSeconds(2);
		waveTxt.text = "";
	}
	
	
	IEnumerator CollectibleWave1()
	{
		waveGenerationOngoing = true;
		
		Instantiate(collectible,new Vector3(2,2,15),collectible.transform.rotation);
		Instantiate(collectible,new Vector3(2,2,17),collectible.transform.rotation);
		Instantiate(collectible,new Vector3(2,2,19),collectible.transform.rotation);
		Instantiate(collectible,new Vector3(2,2,21),collectible.transform.rotation);
		//-------
		Instantiate(collectible,new Vector3(2,-2,25),collectible.transform.rotation);
		Instantiate(collectible,new Vector3(2,-2,27),collectible.transform.rotation);
		Instantiate(collectible,new Vector3(2,-2,29),collectible.transform.rotation);
		Instantiate(collectible,new Vector3(2,-2,31),collectible.transform.rotation);
		//--------
		Instantiate(collectible,new Vector3(-2,2,35),collectible.transform.rotation);
		Instantiate(collectible,new Vector3(-2,2,37),collectible.transform.rotation);
		Instantiate(collectible,new Vector3(-2,2,39),collectible.transform.rotation);
		Instantiate(collectible,new Vector3(-2,2,41),collectible.transform.rotation);
		//--------
		Instantiate(collectible,new Vector3(-2,-2,45),collectible.transform.rotation);
		Instantiate(collectible,new Vector3(-2,-2,47),collectible.transform.rotation);
		Instantiate(collectible,new Vector3(-2,-2,49),collectible.transform.rotation);
		Instantiate(collectible,new Vector3(-2,-2,51),collectible.transform.rotation);
		
		yield return new WaitForSeconds(1);
		
		waveGenerationOngoing = false;
	}	
	
	
	IEnumerator CollectibleWave2()
	{
		waveGenerationOngoing = true;
		
		Instantiate(collectible,new Vector3(2,2,15),collectible.transform.rotation);
		Instantiate(collectible,new Vector3(2,-2,20),collectible.transform.rotation);
		Instantiate(collectible,new Vector3(-2,-2,25),collectible.transform.rotation);
		Instantiate(collectible,new Vector3(-2,2,30),collectible.transform.rotation);
		//-------
		Instantiate(collectible,new Vector3(2,2,40),collectible.transform.rotation);
		Instantiate(collectible,new Vector3(2,-2,45),collectible.transform.rotation);
		Instantiate(collectible,new Vector3(-2,-2,50),collectible.transform.rotation);
		Instantiate(collectible,new Vector3(-2,2,55),collectible.transform.rotation);
		//-------
		Instantiate(collectible,new Vector3(2,2,65),collectible.transform.rotation);
		Instantiate(collectible,new Vector3(2,-2,70),collectible.transform.rotation);
		Instantiate(collectible,new Vector3(-2,-2,75),collectible.transform.rotation);
		Instantiate(collectible,new Vector3(-2,2,80),collectible.transform.rotation);
		//-------
		Instantiate(collectible,new Vector3(2,2,90),collectible.transform.rotation);
		Instantiate(collectible,new Vector3(2,-2,95),collectible.transform.rotation);
		Instantiate(collectible,new Vector3(-2,-2,100),collectible.transform.rotation);
		Instantiate(collectible,new Vector3(-2,2,105),collectible.transform.rotation);
		//-------
		
		yield return new WaitForSeconds(1);
		
		waveGenerationOngoing = false;
	}

	IEnumerator CollectibleWave3()
	{
		waveGenerationOngoing = true;
		
		Instantiate(collectible,new Vector3(0,2,15),collectible.transform.rotation);
		Instantiate(collectible,new Vector3(2,0,20),collectible.transform.rotation);
		Instantiate(collectible,new Vector3(0,-2,25),collectible.transform.rotation);
		Instantiate(collectible,new Vector3(-2,0,30),collectible.transform.rotation);
		//-------
		Instantiate(collectible,new Vector3(0,2,40),collectible.transform.rotation);
		Instantiate(collectible,new Vector3(2,0,45),collectible.transform.rotation);
		Instantiate(collectible,new Vector3(0,-2,50),collectible.transform.rotation);
		Instantiate(collectible,new Vector3(-2,0,55),collectible.transform.rotation);
		//-------
		Instantiate(collectible,new Vector3(0,2,35),collectible.transform.rotation);
		Instantiate(collectible,new Vector3(2,0,37),collectible.transform.rotation);
		Instantiate(collectible,new Vector3(0,-2,39),collectible.transform.rotation);
		Instantiate(collectible,new Vector3(-2,0,41),collectible.transform.rotation);
		//-------
		Instantiate(collectible,new Vector3(0,2,45),collectible.transform.rotation);
		Instantiate(collectible,new Vector3(2,0,47),collectible.transform.rotation);
		Instantiate(collectible,new Vector3(0,-2,49),collectible.transform.rotation);
		Instantiate(collectible,new Vector3(-2,0,51),collectible.transform.rotation);
		//-------
		
		yield return new WaitForSeconds(1);
		
		waveGenerationOngoing = false;
	}	
	
	IEnumerator CollectibleWave4()
	{
		waveGenerationOngoing = true;
		
		Instantiate(collectible,new Vector3(0,2,15),collectible.transform.rotation);
		Instantiate(collectible,new Vector3(2,0,15),collectible.transform.rotation);
		Instantiate(collectible,new Vector3(0,-2,15),collectible.transform.rotation);
		Instantiate(collectible,new Vector3(-2,0,15),collectible.transform.rotation);
		//-------
		Instantiate(collectible,new Vector3(2,2,20),collectible.transform.rotation);
		Instantiate(collectible,new Vector3(2,-2,20),collectible.transform.rotation);
		Instantiate(collectible,new Vector3(-2,-2,20),collectible.transform.rotation);
		Instantiate(collectible,new Vector3(-2,2,20),collectible.transform.rotation);
		//-------
		Instantiate(collectible,new Vector3(0,2,25),collectible.transform.rotation);
		Instantiate(collectible,new Vector3(2,0,25),collectible.transform.rotation);
		Instantiate(collectible,new Vector3(0,-2,25),collectible.transform.rotation);
		Instantiate(collectible,new Vector3(-2,0,25),collectible.transform.rotation);
		//-------
		Instantiate(collectible,new Vector3(2,2,30),collectible.transform.rotation);
		Instantiate(collectible,new Vector3(2,-2,30),collectible.transform.rotation);
		Instantiate(collectible,new Vector3(-2,-2,30),collectible.transform.rotation);
		Instantiate(collectible,new Vector3(-2,2,30),collectible.transform.rotation);
		
		yield return new WaitForSeconds(1);
		
		waveGenerationOngoing = false;
	}	

	IEnumerator CollectibleWave5()
	{
		waveGenerationOngoing = true;
		
		Instantiate(obstacle,new Vector3(-2,2,15),obstacle.transform.rotation);
		Instantiate(obstacle,new Vector3(2,2,15),obstacle.transform.rotation);
		Instantiate(collectible,new Vector3(-2,-2,20),collectible.transform.rotation);
		Instantiate(collectible,new Vector3(2,-2,20),collectible.transform.rotation);
		Instantiate(collectible,new Vector3(-2,-2,25),collectible.transform.rotation);
		Instantiate(collectible,new Vector3(2,-2,25),collectible.transform.rotation);
		//-------
		Instantiate(obstacle,new Vector3(-2,-2,30),obstacle.transform.rotation);
		Instantiate(obstacle,new Vector3(2,-2,30),obstacle.transform.rotation);
		Instantiate(collectible,new Vector3(-2,2,35),collectible.transform.rotation);
		Instantiate(collectible,new Vector3(2,2,35),collectible.transform.rotation);
		Instantiate(collectible,new Vector3(-2,2,40),collectible.transform.rotation);
		Instantiate(collectible,new Vector3(2,2,40),collectible.transform.rotation);
		//-------
		Instantiate(obstacle,new Vector3(-2,2,45),obstacle.transform.rotation);
		Instantiate(obstacle,new Vector3(2,2,45),obstacle.transform.rotation);
		Instantiate(collectible,new Vector3(-2,-2,50),collectible.transform.rotation);
		Instantiate(collectible,new Vector3(2,-2,50),collectible.transform.rotation);
		Instantiate(collectible,new Vector3(-2,-2,55),collectible.transform.rotation);
		Instantiate(collectible,new Vector3(2,-2,55),collectible.transform.rotation);
		//-------
		Instantiate(obstacle,new Vector3(-2,-2,60),obstacle.transform.rotation);
		Instantiate(obstacle,new Vector3(2,-2,60),obstacle.transform.rotation);
		Instantiate(collectible,new Vector3(-2,2,65),collectible.transform.rotation);
		Instantiate(collectible,new Vector3(2,2,65),collectible.transform.rotation);
		Instantiate(collectible,new Vector3(-2,2,70),collectible.transform.rotation);
		Instantiate(collectible,new Vector3(2,2,70),collectible.transform.rotation);
		//-------
		
		
		yield return new WaitForSeconds(1);
		
		waveGenerationOngoing = false;
	}

	IEnumerator CollectibleWave6()
	{
		waveGenerationOngoing = true;
		
		Instantiate(obstacle,new Vector3(-2,2,15),obstacle.transform.rotation);
		Instantiate(obstacle,new Vector3(2,2,15),obstacle.transform.rotation);
		Instantiate(obstacle,new Vector3(2,-2,15),obstacle.transform.rotation);
		Instantiate(collectible,new Vector3(-2,-2,15),collectible.transform.rotation);
		//-------
		Instantiate(obstacle,new Vector3(-2,2,30),obstacle.transform.rotation);
		Instantiate(obstacle,new Vector3(2,2,30),obstacle.transform.rotation);
		Instantiate(obstacle,new Vector3(-2,-2,30),obstacle.transform.rotation);
		Instantiate(collectible,new Vector3(2,-2,30),collectible.transform.rotation);
		//-------
		Instantiate(obstacle,new Vector3(-2,2,45),obstacle.transform.rotation);
		Instantiate(obstacle,new Vector3(-2,-2,45),obstacle.transform.rotation);
		Instantiate(obstacle,new Vector3(2,-2,45),obstacle.transform.rotation);
		Instantiate(collectible,new Vector3(2,2,45),collectible.transform.rotation);
		//-------
		Instantiate(obstacle,new Vector3(-2,-2,60),obstacle.transform.rotation);
		Instantiate(obstacle,new Vector3(2,2,60),obstacle.transform.rotation);
		Instantiate(obstacle,new Vector3(2,-2,60),obstacle.transform.rotation);
		Instantiate(collectible,new Vector3(-2,2,60),collectible.transform.rotation);
		//-------
		
		yield return new WaitForSeconds(1);
		
		waveGenerationOngoing = false;
	}
	
	
	
	void OnGUI()
	{
		if(GUI.Button(new Rect(10,10,100,100),"w1")) StartCoroutine("Stage1");
	}
}
