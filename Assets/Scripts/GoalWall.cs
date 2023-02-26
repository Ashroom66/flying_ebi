using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoalWall : MonoBehaviour {
	public GameObject canvas;

	// Use this for initialization
	void Start () {
		canvas.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		// タイトル
		if(Input.GetButtonDown("Title")) {
			SceneManager.LoadScene("title");
		}
		
	}

	void OnTriggerEnter2D (Collider2D c) {
		if(c.gameObject.tag == "Ebi") {
			if(c.gameObject.GetComponent<EbiMove>().isoriginal) {
				// ゴール
				canvas.SetActive(true);
			}
		}
		
	}
}
