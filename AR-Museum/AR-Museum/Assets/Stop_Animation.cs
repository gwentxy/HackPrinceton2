using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stop_Animation : MonoBehaviour {

	private AudioSource audioSource;
	private Animation animation1;

	// Use this for initialization
	void Start () {


	}

	// Update is called once per frame
	void Update () {
		AudioSource audioSource = GetComponent<AudioSource>();
		Animation animation1 = GetComponent<Animation>();
	
		if (!audioSource.isPlaying) {
			animation1.Stop();
		}
	}
}
