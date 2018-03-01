using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class delLife : MonoBehaviour {
	public UnityEngine.UI.Text lifesDisplay;

	void Start () {
	}

	void Update () {
		
	}

	void  OnCollisionEnter2D(Collision2D col) {
		double lifes = double.Parse (lifesDisplay.text);
		lifes = lifes - 1;
		lifesDisplay.text = lifes.ToString();
	}
}
