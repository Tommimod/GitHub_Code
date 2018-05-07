using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCube : MonoBehaviour {
	private GameObject[] Spawns_Line;
	private GameObject[] Underline;

	public GameObject Cube;
	public GameObject Capsul;

	/*public float Intensivity;*/
	private bool _SP_Line = true;
	private bool _SP_UnderLine = true;

	// Use this for initialization
	public void Start () {
		Spawns_Line = GameObject.FindGameObjectsWithTag("Spawn");
		Underline =  GameObject.FindGameObjectsWithTag("Underline");
	}
	
	// Update is called once per frame
	void Update () {
		if(_SP_Line==true){
		StartCoroutine("Poexali_Line");
		_SP_Line=false;
		}

		if(_SP_UnderLine==true){
		StartCoroutine("Poexali_UnderLine");
		_SP_UnderLine=false;
		}

	}

	public void SmallBig(){
		var zero = new Vector3(0,0,0);
		var origin_x = this.transform.localScale.x; 
		var origin_y = this.transform.localScale.y; 
		var origin_z = this.transform.localScale.z; 
		var origin = new Vector3(origin_x,origin_y,origin_z);
		this.transform.localScale = Vector3.Lerp(zero,origin,.5f);
	}

	void RangeMass(){
		int _position = Random.Range(0,3);
		Instantiate(Cube, Spawns_Line[_position].transform.position, Quaternion.Euler(0,0,Random.Range(-360,360)));
	}

	void spUnderline(){
		int _position = Random.Range(0,2);
		Instantiate(Capsul, Underline[_position].transform.position,Quaternion.Euler(0,0,0) );
	}



	IEnumerator Poexali_Line(){
		RangeMass();
		yield return new  WaitForSeconds(2);
		yield return _SP_Line=true;

	}
	IEnumerator Poexali_UnderLine(){
		spUnderline();
		yield return new  WaitForSeconds(10);
		yield return _SP_UnderLine=true;

	}

}
