﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteObject : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	private void OnTriggerEnter(Collider other) {
		Destroy(other.gameObject);
		
		if(CubeAngle.checkd==false){
			CubeAngle.Error();
		}
	}
}
