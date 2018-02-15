using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundMananger : MonoBehaviour {

	public static AudioClip deathSound, jumpSound, restartSound, pointSound;
	static AudioSource AudioSrc;

	// Use this for initialization
	void Start () {

		deathSound = Resources.Load<AudioClip> ("death");
		jumpSound = Resources.Load<AudioClip> ("jump");
		restartSound = Resources.Load<AudioClip> ("restart");
		pointSound = Resources.Load<AudioClip> ("point");

		AudioSrc = GetComponent<AudioSource> ();
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public static void PlaySound (string clip)
	{
		
		switch (clip) {	
		case "death":
			AudioSrc.PlayOneShot (deathSound);
			break;
		case "jump":
			AudioSrc.PlayOneShot (jumpSound);	
			break;
		case "restart":
			AudioSrc.PlayOneShot (deathSound);
			break;
		case "point":
			AudioSrc.PlayOneShot (pointSound);
			break;
		}
	}
}