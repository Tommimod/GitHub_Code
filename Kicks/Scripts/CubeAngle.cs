using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeAngle : MonoBehaviour {

private float min,max;
static public bool checkd=false;
private GameObject Ship;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	}

	private void OnTriggerEnter(Collider other) {
		var Angle= transform.rotation.eulerAngles.z;
		min= Angle - 20f;
	    max= Angle + 20f;
		Ship = GameObject.FindGameObjectWithTag("MainCamera");
		var ShipTr = Ship.transform.rotation.eulerAngles.z;
        checkd=true;
		if(ShipTr>=min && ShipTr<=max){
			Good();
		} else Error();
	}

  static public void Error(){
        Warn_SC.Open();
    }

    void Good(){
    }
}
