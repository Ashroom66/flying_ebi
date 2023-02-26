using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletLinear : MonoBehaviour {
	public float speed;	// 弾速
	public int life;	// 寿命:弾が消えるまで
	public int dmg;		// 弾の与える威力
	public float v0;	// 初速=ebi速代入

	// Use this for initialization
	void Start () {
		GetComponent<Rigidbody2D>().velocity = transform.up.normalized * (v0+speed);
	}
	
	// Update is called once per frame
	void Update () {
		if(--life <= 0) {Destroy(this.gameObject);}
	}

	void OnTriggerEnter2D (Collider2D c) {
		if(c.gameObject.tag == "Breakable") {
			// ダメージ与える処理
			BreakableWall wall = c.GetComponent<BreakableWall>();
			wall.bullethit = true;
			wall.hp -= dmg;
			Destroy(this.gameObject);
		}
		if(c.gameObject.tag == "Wall") {
			Destroy(this.gameObject);
		}
	}
}
