using UnityEngine;
using System.Collections;

public class PlayerScripts : MonoBehaviour {

	public float jumpForece;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetButtonDown ("Jump") || (Input.touches.Length!=0&&Input.GetTouch(0).phase == TouchPhase.Ended)) {
			GetComponent<Rigidbody>().velocity = new Vector3(0,jumpForece,0);
		}
	}

	void OnTriggerEnter(Collider other)
	{
		Application.LoadLevel (Application.loadedLevel);
	}
}
