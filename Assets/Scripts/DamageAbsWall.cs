using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageAbsWall : MonoBehaviour {
	private SpriteRenderer sr;
	private GameObject respawn;
	// Use this for initialization
	void Start () {
		sr = gameObject.GetComponent<SpriteRenderer>();
	}
	void OnTriggerStay2D (Collider2D c) {
		if(c.gameObject.tag == "Ebi") {
			// ダメージ与える処理
			if(c.gameObject.GetComponent<EbiMove>().isoriginal) {
				// original海老処理
			} else {
				Destroy(c.gameObject);
			}
		}
	}
	void OnTriggerEnter2D (Collider2D c) {
		if(c.gameObject.tag == "Ebi") {
			// ダメージ与える処理
			if(c.gameObject.GetComponent<EbiMove>().isoriginal) {
				// original海老処理
				respawn = GameObject.Find("RespawnPoint");
				c.gameObject.GetComponent<Transform>().position = respawn.GetComponent<Transform>().position;
			} else {
				Destroy(c.gameObject);
			}
		}
	}
}
