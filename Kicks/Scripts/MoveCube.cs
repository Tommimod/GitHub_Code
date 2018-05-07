using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCube : MonoBehaviour {
public float Intensivity=1;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(new Vector3(0,0,-1)*Time.deltaTime*Intensivity);
	}
}
