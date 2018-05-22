using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class ArmMovement : MonoBehaviour {

    public GameObject RobotHandAnchor;
    Vector3 ManipulatorPrevPosition;
    
	// Use this for initialization
	void Start () {
        ManipulatorPrevPosition = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 current = transform.position;
        Vector3 delta = current - ManipulatorPrevPosition;
        ManipulatorPrevPosition = current;
        RobotHandAnchor.transform.position = RobotHandAnchor.transform.position + delta * 10;

    }
}
