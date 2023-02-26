using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextShake : MonoBehaviour {
	float shakehaba = 0.1f;
	Vector3 startpos;
	int xf,yf;

	// Use this for initialization
	void Start () {
		startpos = transform.position;
		xf = Random.Range(3,15+1);
		yf = Random.Range(3,15+1);
	}
	
	// Update is called once per frame
	void Update () {
		float levelx = Mathf.Abs(Mathf.Sin(Time.time * xf));
		float levely = Mathf.Abs(Mathf.Sin(Time.time * yf));
		transform.position = new Vector3(startpos.x + (levelx * shakehaba), startpos.y + (levely * shakehaba), -0.1f);	
	}
}
