using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutOfArea : MonoBehaviour {
	private GameObject respawn;
	void OnTriggerEnter2D (Collider2D c) {
		if(c.gameObject.tag == "Ebi") {
			if(c.gameObject.GetComponent<EbiMove>().isoriginal) {
				// リスポーン
				respawn = GameObject.Find("RespawnPoint");
				c.gameObject.GetComponent<Transform>().position = respawn.GetComponent<Transform>().position;
				Rigidbody2D rb = c.gameObject.GetComponent<Rigidbody2D>();
				rb.velocity = new Vector2(0,0);
			}
		}
		
	}
}
