using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooterRkeys : MonoBehaviour {
	private HingeJoint2D joint;

	void Start() {
		joint = GetComponent<HingeJoint2D>(); // Get hingejoint
	}


	void Update () {
		if(Input.GetKeyDown("l")) {
			joint.useMotor = true;
		}
		if(Input.GetKeyUp("l")) {
			joint.useMotor = false;
		}
	}

}
