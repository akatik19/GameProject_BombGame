using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class launch : MonoBehaviour {
	public Rigidbody2D rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D>();
		rb.velocity = new Vector3(Random.Range(45,55), Random.Range(1,5), Random.Range(1,5));
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
