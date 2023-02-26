using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToNextButton : MonoBehaviour {
	public GameObject cam;
	public void OnClick() {
		cam.GetComponent<TopButton>().pressed = true;
	}
}
