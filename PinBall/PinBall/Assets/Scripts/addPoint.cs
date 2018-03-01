using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class addPoint : MonoBehaviour {
	public double value;
	public UnityEngine.UI.Text pointsDisplay;
	public UnityEngine.UI.Text lifesDisplay;

	void Start () {
	}

	void Update () {
		
	}

	void  OnCollisionEnter2D(Collision2D col) {
		double points = double.Parse (pointsDisplay.text);
		points = points + value;
		pointsDisplay.text = points.ToString();
		if (!Convert.ToBoolean(points % 7000)) {
			double lifes = double.Parse (lifesDisplay.text);
			lifes = lifes + 1;
			lifesDisplay.text = lifes.ToString();
		}
	}
}
