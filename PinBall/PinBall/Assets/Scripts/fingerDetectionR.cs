using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fingerDetectionR : MonoBehaviour {
	public HingeJoint2D joint;

	public void PrintActiveMessage () {
		joint.useMotor = false;

	}

	public void PrintDeactivatemeMessage () {
		joint.useMotor = true;
	}
}
