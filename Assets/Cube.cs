using UnityEngine;
using System.Collections;

public class Cube : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Debug.Log("Hello Git");
	}
	
	// Update is called once per frame
	void Update () {
	
		transform.Rotate (Vector3.up, 1.0f);
	}
}
