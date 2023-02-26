using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelGimmic : MonoBehaviour {
	void OnTriggerEnter2D (Collider2D c) {
		if(c.gameObject.tag == "Ebi") {
			if(c.gameObject.GetComponent<EbiMove>().isoriginal) {
				// 消去
				Destroy(this.gameObject);
			}
		}
		
	}
}
