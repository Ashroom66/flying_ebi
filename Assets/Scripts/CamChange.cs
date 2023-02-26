using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamChange : MonoBehaviour {
	public GameObject ebicam;
	public GameObject mapcam;
	public bool ebinow;

	// Use this for initialization
	void Start () {
		mapcam.SetActive(false);
		ebinow = true;
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButtonDown("CamChange")) {
			if(ebinow) {
				mapcam.SetActive(true);
				ebicam.SetActive(false);
			} else {
				ebicam.SetActive(true);
				mapcam.SetActive(false);
			}
			ebinow = !ebinow;
		}
		
	}
}
