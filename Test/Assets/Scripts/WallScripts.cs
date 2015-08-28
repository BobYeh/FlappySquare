using UnityEngine;
using System.Collections;

public class WallScripts : MonoBehaviour {

	public float speed;
	public GameObject wallPrefab;
	public float interval;

	// Use this for initialization
	void Start () {
		Destroy (gameObject, 5f);
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (speed * Time.deltaTime, 0, 0);
	}
}
