using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateWall : MonoBehaviour {
	public float rotatespd;
	public bool rev;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		int sign = 1;
		if(rev) {sign *= -1;}
		/*
		if(Input.GetKey(KeyCode.H)) {transform.Rotate (0,0,rotatespd * sign);}
		if(Input.GetKey(KeyCode.K)) {transform.Rotate (0,0,rotatespd * -1 * sign);}
		*/
		int x = 0;
		//x = Input.GetAxisRaw("WallRotate");
		//if(Mathf.Abs(x) < 0.5) {x = 0;}
		//x *= -1;
		if(Input.GetButton("WallRotateL")) {
			x = 1;
		} else if(Input.GetButton("WallRotateR")) {
			x = -1;
		}
		transform.Rotate (0,0,x * rotatespd * sign);
	}
}
