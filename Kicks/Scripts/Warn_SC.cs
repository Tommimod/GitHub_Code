using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warn_SC : MonoBehaviour {
static	private GameObject[] Warning_mass;
static private bool[] closed;
static private bool q,e,r,t,y,u,i,o=false;

static private bool _close;

	// Use this for initialization
	void Start () {
		Warning_mass = GameObject.FindGameObjectsWithTag("Warn");
		for(int i=0;  i<8; i++) {Warning_mass[i].SetActive(false);}
		closed = new bool[]{q,e,r,t,y,u,i,o};
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Space)) Close();
	}

	static public void Open(){
		for(int i=0;  i<8; i++){
			Warning_mass[i].SetActive(true);
			closed[i]=false;
		}
	}

	static public void Close(){

			for(int i=0;  i<8; i++){
				if(closed[i]!=true){
				    Warning_mass[i].SetActive(false);
				    closed[i]=true;
				    break;
				} 
			} 
	}
}
