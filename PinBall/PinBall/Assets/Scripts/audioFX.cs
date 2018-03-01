using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioFX : MonoBehaviour {
	public AudioClip impact;
	public AudioSource audioSource;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void  OnCollisionEnter2D(Collision2D col) {
		audioSource.PlayOneShot(impact);
	}
}
