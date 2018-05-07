using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Right : MonoBehaviour {

public float Intensivity;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float h = Input.GetAxis("Horizontal") * Intensivity;
		float v = Input.GetAxis("Vertical") * Intensivity;
		transform.Translate(new Vector3(h,0,v));
	}
}
