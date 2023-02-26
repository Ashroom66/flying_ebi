using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EbiMove : MonoBehaviour {
	public float movespd;
	public float jumppow;
	private float x,y;
	public bool isoriginal;	// オリジナル=クローンではない
	private Rigidbody2D rb;
	private Vector2 force;
	private Vector3 angle;
	public GameObject bullet;	// 使う弾
	public int shootinterval;	// クールタイム
	private int sintervalcount;	// クールタイムカウント用				
	public float recoil;		// 反動
	private Vector3 forspeedmeasure1;
	private Vector3 forspeedmeasure2;
	public float shotdist;		// 発射距離
	private Quaternion shotangle;
	private Vector3 shotpos;

	public GameObject clone;	// クローン兄貴
	public int clonelife;		// クローンの寿命

	// Use this for initialization
	void Start () {
		forspeedmeasure1 = transform.position;
		rb = this.GetComponent<Rigidbody2D>();
		sintervalcount = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if(!isoriginal && --clonelife <= 0) {Destroy(this.gameObject);}
		if(!isoriginal && clonelife <= 60) {
			float level = Mathf.Abs(Mathf.Sin(Time.time * 15));
			gameObject.GetComponent<SpriteRenderer>().color = new Color(1f,1f,1f,(level/2 + 0.5f)*0.75f);
		}

		x = Input.GetAxisRaw("Horizontal");
		y = Input.GetAxisRaw("Vertical");
		rb.AddForce(new Vector2(x*movespd / 10,0));

		if(Input.GetButtonDown("Jump")) {
			angle = transform.localEulerAngles;
			force = new Vector2(Mathf.Cos((angle.z - 270) * Mathf.PI / 180), Mathf.Sin((angle.z - 270) * Mathf.PI / 180));
			rb.AddForce(force * jumppow / 10, ForceMode2D.Impulse);
		}
//		Instantiate(img, shotorigin, rotation);
		
		forspeedmeasure1 = new Vector3(transform.position.x - forspeedmeasure1.x, transform.position.y - forspeedmeasure1.y, transform.position.z - forspeedmeasure1.z);
		if(--sintervalcount <= 0 && Input.GetButton("Shoot")) {
			// 弾撃つ
			angle = transform.localEulerAngles;
			shotangle.eulerAngles = new Vector3(0,0,transform.localEulerAngles.z + 90);
			shotpos = new Vector3(transform.position.x + Mathf.Cos((angle.z + 180) * Mathf.PI / 180) * shotdist, transform.position.y + Mathf.Sin((angle.z + 180) * Mathf.PI / 180) * shotdist,0);
			GameObject mybullet = Instantiate(bullet, shotpos, shotangle);
			
			// 初速計算
			forspeedmeasure2 = new Vector3(Mathf.Cos((angle.z + 180) * Mathf.PI / 180), Mathf.Sin((angle.z + 180) * Mathf.PI / 180), 0);
			float dotcalc = Vector3.Dot(forspeedmeasure1, forspeedmeasure2);
			dotcalc *= forspeedmeasure1.magnitude;
			//mybullet.GetComponent<BulletLinear>().v0 = dotcalc / 4;

			// 反動
			rb.AddForce(transform.right.normalized * recoil, ForceMode2D.Impulse);

			// クールタイム
			sintervalcount = shootinterval;
		}

		// クローン生成
		if(isoriginal && Input.GetButtonDown("Clone")) {
			Instantiate(clone, transform.position, transform.rotation);
		}
	}
}
