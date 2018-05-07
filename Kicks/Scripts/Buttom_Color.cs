using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttom_Color : MonoBehaviour {

	public GameObject Left, Middle, Right, Player;

	public Material White, Yellow, Inv;

	private bool alpha=true;

	static public bool invert;

	// Use this for initialization
	void Start () {
		Middle.GetComponent<MeshRenderer>().material=Yellow;
		Inv.color = new Color(255/255,255/255,255/255,0/255);
		invert=false;
	}
	
	// Update is called once per frame
	void Update () {

		var z = Player.GetComponent<Transform>().localEulerAngles.z;
		var angle = (360+z)%360;

		if(LerpPos.moveLeft==true){ 
			Left.GetComponent<MeshRenderer>().material=Yellow;
		    Middle.GetComponent<MeshRenderer>().material=White;
			Right.GetComponent<MeshRenderer>().material=White;
		}

		if(LerpPos.moveMiddle==true){ 
		    Middle.GetComponent<MeshRenderer>().material=Yellow;
			Right.GetComponent<MeshRenderer>().material=White;
		}
			Left.GetComponent<MeshRenderer>().material=White;

		if(LerpPos.moveRight==true){ 
			Left.GetComponent<MeshRenderer>().material=White;
		    Middle.GetComponent<MeshRenderer>().material=White;
			Right.GetComponent<MeshRenderer>().material=Yellow;
		}

		if(angle>90f && angle<270f){
			invert = true;
			if(alpha==true) StartCoroutine("Alpha_Change");	
		 } else {
			Inv.color = new Color(255/255,255/255,255/255,0/255);
	  	    invert=false;
		 }

		 GameObject.Find("Speed").GetComponent<TextMesh>().text = 
		 Mathf.RoundToInt(Mathf.Lerp(69f, 72f, Mathf.PingPong(Time.time*2, 1))).ToString();

	}
	
	IEnumerator Alpha_Change(){
		alpha = false;
		Inv.color = new Color(255/255,255/255,255/255,0/255);
		yield return new WaitForSeconds(1f); 
		Inv.color = new Color(255/255,255/255,255/255,255/255);
		yield return new WaitForSeconds(1f);
		 yield return alpha = true;
	}
}
