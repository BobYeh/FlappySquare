using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Scores : MonoBehaviour {

	public static Scores mInstance;

	public static Scores instance
	{
		get{
			if(mInstance == null)
				mInstance = FindObjectOfType<Scores>();
			return mInstance;
		}
	}

	private Text mText;
	public float score
	{
		get;
		private set;
	}

	public void reset()
	{
		score = 0;
	}

	// Use this for initialization
	void Start () {
		if (instance != this)
			Destroy (this);
		mText = GetComponentInChildren<Text> ();
		score = 0;
	}
	
	// Update is called once per frame
	void Update () {
		score += Time.deltaTime;
		mText.text = "Score: "+(int)(score*100);
	}

	void OnDestroy(){
		PlayerPrefs.SetFloat ("Score",score * 100);
	}
	
}
