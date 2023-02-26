using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageWall : MonoBehaviour {
	public int cooltime;
	public int ct;
	private SpriteRenderer sr;
	private GameObject respawn;
	// Use this for initialization
	void Start () {
		ct = 0;
		sr = gameObject.GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
		if(--ct <= 60 && ct > 0) {
			float level = Mathf.Abs(Mathf.Sin(Time.time * 15));
			sr.color = new Color(0.25f,0.75f,1f,level/2 + 0.5f);
		}
		if(ct == 0) {
			// 赤色
			sr.color = new Color(1f, 0.25f, 0.25f, 1f);
		}
		
	}
	void OnTriggerStay2D (Collider2D c) {
		if(c.gameObject.tag == "Ebi" && ct <= 0) {
			// ダメージ与える処理
			if(c.gameObject.GetComponent<EbiMove>().isoriginal) {
				// original海老処理
			} else {
				Destroy(c.gameObject);
			}
			ct = cooltime;
			sr.color = new Color(0.25f, 0.75f, 1f, 1f);
		}
	}
	void OnTriggerEnter2D (Collider2D c) {
		if(c.gameObject.tag == "Ebi" && ct <= 0) {
			// ダメージ与える処理
			if(c.gameObject.GetComponent<EbiMove>().isoriginal) {
				// original海老処理
				respawn = GameObject.Find("RespawnPoint");
				c.gameObject.GetComponent<Transform>().position = respawn.GetComponent<Transform>().position;
				Rigidbody2D rb = c.gameObject.GetComponent<Rigidbody2D>();
				rb.velocity = new Vector2(0,0);
			} else {
				Destroy(c.gameObject);
			}
			ct = cooltime;
			sr.color = new Color(0.25f, 0.75f, 1f, 1f);
		}
	}
}
