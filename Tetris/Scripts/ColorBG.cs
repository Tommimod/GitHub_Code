using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorBG : MonoBehaviour {
     private Color Newcolor;

	// Use this for initialization
	void Start () {
		Newcolor=Color.red;
		GetComponent<SpriteRenderer>().color = Newcolor;
	}
	
	// Update is called once per frame
	void Update () {
		
		Newcolor = Color.Lerp(Color.red, Color.blue, Mathf.PingPong(Time.time/10, 1));
		
		GetComponent<SpriteRenderer>().color = Newcolor;
	}
	
			


		}
