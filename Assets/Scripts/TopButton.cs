using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TopButton : MonoBehaviour {
	public Button gamestart;
	public Button exit;
	public GameObject menu1;
	public GameObject menu2;
	public bool pressed = false;
	void Start() {
		gamestart.Select();
		menu2.SetActive(false);
	}
	void Update() {
		if(pressed == true) {
			menu1.SetActive(false);
			menu2.SetActive(true);
			this.gameObject.GetComponent<NextButton>().next = true;
			pressed = false;
		}
	}
}
