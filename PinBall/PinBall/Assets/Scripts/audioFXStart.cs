using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioFXStart : MonoBehaviour {
	public AudioClip impact;
	public AudioSource audioSource;

	// Use this for initialization
	void Start () {
		audioSource.PlayOneShot(impact);
	}
	
	// Update is called once per frame
	void  OnCollisionEnter2D(Collision2D col) {
		
	}
}
