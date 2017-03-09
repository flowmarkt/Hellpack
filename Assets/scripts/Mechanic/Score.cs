using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	static private int scoreToDisplay = 0;
	static private int score = 0;
	static private SFXOnScore sfx;
	static public Text scoreText;
	
	void Start()
	{
		sfx = gameObject.GetComponent<SFXOnScore>();
		StartCoroutine("FollowScoreOnDisplay");
		scoreText = (GameObject.Find("TxtScore")).GetComponent<Text>();
	}

	static public int GetScore()
	{
		return score;
	}
	static public int GetScoreToDisplay()
	{
		return scoreToDisplay;
	}
	
	static public void IncrementScore()
	{
		++score;
	}

    static public void EndTune()
    {
        //TODO
    }
	
	IEnumerator FollowScoreOnDisplay()
	{
		while(true)
		{
			yield return new WaitForSeconds(0.2f);				//TODO: zenéhez "szinkronizálni"
			if (scoreToDisplay<score)
			{
				++scoreToDisplay;
				scoreText.text = scoreToDisplay.ToString();
				sfx.PlayScoreSFX();
			}
		}
	}
}
