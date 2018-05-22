using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[ExecuteInEditMode]
public class Armmovement : MonoBehaviour {

    Vector3 ManipulatorPrevPosition;
    GameObject RobotHandAnchor;
	// Use this for initialization
	void Start () {
        RobotHandAnchor = GameObject.Find("RobotFistTK");
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
