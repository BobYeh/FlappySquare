using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameOverScripts : MonoBehaviour {

	private Text mText;

	// Use this for initialization
	void Start () {
		mText = GetComponent<Text> ();
		mText.text = "Scores: "+(int)PlayerPrefs.GetFloat("Score");
		//mText.text = "Scores: ";
	}
}
