using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXOnScore : MonoBehaviour {

	AudioSource src;
	
	const float pitchI		=	1;
	const float pitchiii	=	19.45f/16.35f;
	const float pitchIV		=	21.83f/16.35f;
	const float pitchTriton	=	23.12f/16.35f;
	const float pitchV		=	24.50f/16.35f;
	const float pitchVI		=	29.14f/16.35f;
	const float pitchI2		= 	2f;
	
	float[] lick = {pitchVI,pitchI2,pitchVI,
						pitchV,pitchI2,pitchV,
						pitchTriton,pitchI2,pitchTriton,
						pitchIV,pitchI2,pitchIV,
						pitchiii,pitchI2,pitchiii,
						pitchI,pitchI2,pitchI};
	int lickIndex = 0;

	// Use this for initialization
	void Start () {
		src = gameObject.GetComponent<AudioSource>();
		src.clip= Resources.Load<AudioClip>("Item2A");
	}
	
	public void PlayScoreSFX()
	{
		src.pitch=lick[lickIndex%lick.Length];
		src.Play();
		++lickIndex;
	}
}
