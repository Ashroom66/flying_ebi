using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakableWall : MonoBehaviour {
	// HP0で消去
	public int hp;
	public bool bullethit;	// 弾が当たったら光らせる為。
	public int ct;

	// Use this for initialization
	void Start () {
		bullethit = false;
	}
	
	// Update is called once per frame
	void Update () {
		if(hp <= 0) {Destroy(this.gameObject);}
		if(bullethit) {
			bullethit = false;
			ct = 6;
		}

		if(--ct > 0) {
			float level = Mathf.Abs(Mathf.Sin(Time.time * 10));
			gameObject.GetComponent<SpriteRenderer>().color = new Color(1f,1f,1f,level/2 + 0.5f);
		} else {
			gameObject.GetComponent<SpriteRenderer>().color = new Color(1f,1f,1f,1f);
		}
	}
}
