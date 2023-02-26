using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NextButton : MonoBehaviour {
	public Button stage0;
	public Button stage1;
	public Button stage2;
	public Button stage3;
	public Button stage4;
	public Button stage5;
	public Button stage6;
	public bool next = false;
	void Update() {
		if(next) {
			stage0.Select();
			next = false;
		}
	}
	
}
