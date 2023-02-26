using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonQuit : MonoBehaviour {
	public void OnClick() {
		Debug.Log("Quit");
		Application.Quit();
	}
}
