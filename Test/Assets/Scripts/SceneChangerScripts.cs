using UnityEngine;
using System.Collections;

public class SceneChangerScripts : MonoBehaviour {

	public string nextScene;
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Submit")) {
			Application.LoadLevel(nextScene);
		}
	}
}
