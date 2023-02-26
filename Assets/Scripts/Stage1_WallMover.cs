using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage1_WallMover : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter2D (Collider2D c) {
		if(c.gameObject.tag == "Wall") {
			
			c.gameObject.GetComponent<Transform>().position = new Vector3(0, 60, 0);
			Rigidbody2D rb = c.gameObject.GetComponent<Rigidbody2D>();
			rb.velocity = new Vector2(0,0);
			
		}
	}
}
