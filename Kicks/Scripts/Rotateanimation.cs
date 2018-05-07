using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotateanimation : MonoBehaviour {

	public Animator Rotate;
	private int oldposition;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(LerpPos.moveLeft==true) {
			oldposition = -30;
			Rotate.SetBool("Left",true);
					} else Rotate.SetBool("Left",false);
		
		if(LerpPos.moveRight==true) {
			oldposition = 30;
			Rotate.SetBool("Right",true);
					} else Rotate.SetBool("Right",false);

		if(LerpPos.moveMiddle==true && oldposition==-30) {
			Rotate.SetBool("Right",true);
					} else Rotate.SetBool("Right",false);

		if(LerpPos.moveMiddle==true && oldposition==30) {
			Rotate.SetBool("Left",true);
					} else Rotate.SetBool("Left",false);
	}
}
