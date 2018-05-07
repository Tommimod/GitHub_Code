using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dead : MonoBehaviour {
public GameObject end;
	// Use this for initialization
	void Start () {
		end.SetActive(false);
	}

	public void DeadMenu(){
       end.SetActive(true);
	   int zero = 0;
	   GameObject.Find("Counts").GetComponent<Text>().text=zero.ToString();
	}
	
	
	// Update is called once per frame
	void Update () {
		
	}

	public void play(){
		Application.LoadLevel("Game");
	}

	public void Menu(){
		Application.LoadLevel("Menu");
	}
}
