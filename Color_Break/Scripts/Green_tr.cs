using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Green_tr : MonoBehaviour {
    public GameObject player;
    public Light light;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void OnTriggerEnter(Collider other) {
        var HP = player.GetComponent<FPSInput>().healht;
        HP += 5;
        Debug.Log(HP);
        light.enabled = false;
	}
}
