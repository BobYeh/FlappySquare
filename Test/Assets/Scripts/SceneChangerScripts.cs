using UnityEngine;
using System.Collections;

public class SceneChangerScripts : MonoBehaviour {

	public string nextScene;
	public string btnString;
	
	/*// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Submit") || (Input.touches.Length!=0&&Input.GetTouch(0).phase == TouchPhase.Ended)) {
			Application.LoadLevel(nextScene);
		}
	}
	*/

	void OnGUI()
	{
		GUIStyle customButton = new GUIStyle ("button");
		customButton.fontSize = 20;
		if(GUI.Button(new Rect(Screen.width/2-60,Screen.height-200,90,60),btnString,customButton))
		{
			Application.LoadLevel(nextScene);
		}
	}
}
