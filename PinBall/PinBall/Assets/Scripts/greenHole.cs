using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class greenHole : MonoBehaviour {
	private GameObject ball;
	private GameObject video;
	public UnityEngine.Video.VideoPlayer videoPlayer;
	public Rigidbody2D rb;
	public UnityEngine.UI.Text pointsDisplay;
	Vector3 startPos;
	public UnityEngine.UI.Text lifesDisplay;

	// Use this for initialization
	void Start () {
		rb.velocity = new Vector3(50, 0, 0);
		video = GameObject.Find("Video");
		ball = GameObject.Find("Ball");
		startPos = ball.transform.position;
		video.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void  OnCollisionEnter2D(Collision2D col) {
		ball.SetActive (false);
		double lifes = double.Parse (lifesDisplay.text);
		if (lifes == 0) {
			videoPlayer.loopPointReached += EndReached;
			videoPlayer.Play ();
			video.SetActive (true);
		} else {
			ball.SetActive (true);
			ball.transform.position = startPos;
			rb.velocity = new Vector3(Random.Range(45,55), Random.Range(1,5), Random.Range(1,5));
		}
	}

	void EndReached(UnityEngine.Video.VideoPlayer vp) {
		ball.SetActive (true);
		video.SetActive (false);
		ball.transform.position = startPos;
		rb.velocity = new Vector3(Random.Range(45,55), Random.Range(1,5), Random.Range(1,5));
		videoPlayer.Stop ();
		double lifes = double.Parse (lifesDisplay.text);
		if (lifes < 0) {
			lifesDisplay.text = "3";
			pointsDisplay.text = "0";
		}
	}
}
