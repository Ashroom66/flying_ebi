using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneButton : MonoBehaviour {
	public string scenename;
	public void OnClick() {
		SceneManager.LoadScene(scenename);
	}
}
