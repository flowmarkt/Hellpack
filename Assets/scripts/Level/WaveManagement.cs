using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WaveManagement : MonoBehaviour {

    public Wave[] collectibleWaves;
    public Wave[] obstacleWaves;
    private int waveNumber = 0;
    public Text waveTxt;

    public bool waveGenerationOngoing = false;

    private IEnumerator WaveRoutine()
    {
        //FRAME
        waveGenerationOngoing = true;
        for(int i = 10; 0 < i; --i)
        {
            if (0 == (waveNumber % 2))
            {
                collectibleWaves[Random.Range(0, collectibleWaves.Length)].GenerateWave(i*9);
            }
            else
            {
                obstacleWaves[Random.Range(0, obstacleWaves.Length)].GenerateWave(i*9+Random.Range(3,5));
            }
            ++waveNumber;
        }

        yield return new WaitForSeconds(1);

        //FRAME
        waveGenerationOngoing = false;    
    }


    // Update is called once per frame
    void Update () {

        // ha nem talál enemyt és véget ért a wave akkor új wave 
        if ((false == waveGenerationOngoing) &&                                           
                    (null == GameObject.Find("Enemy(Clone)")) &&
                        (null == GameObject.Find("Collectible(Clone)")) &&
                            (null == GameObject.Find("Obstacle(Clone)")))                   
        {
            StartCoroutine("WaveRoutine");
        }
    }
}
