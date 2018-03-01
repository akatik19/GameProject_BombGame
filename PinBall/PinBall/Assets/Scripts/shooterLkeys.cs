using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooterLkeys : MonoBehaviour {
	private HingeJoint2D joint;

	void Start() {
		joint = GetComponent<HingeJoint2D>(); // Get hingejoint
	}


	void Update () {
		if(Input.GetKeyDown("a")) {
			joint.useMotor = true;
		}
		if(Input.GetKeyUp("a")) {
			joint.useMotor = false;
		}
	}

}
