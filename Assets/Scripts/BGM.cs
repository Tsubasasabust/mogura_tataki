using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGM : MonoBehaviour {
    public AudioClip[] clips;
    AudioSource audio;
	// Use this for initialization
	void Start () {
		audio = GetComponent<AudioSource>();
		audio.clip = clips[0];
        audio.Play();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
