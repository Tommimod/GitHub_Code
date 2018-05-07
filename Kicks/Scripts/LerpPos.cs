using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpPos : MonoBehaviour {

	private Vector3 left, midlle, right;

	private Vector3 PlayerPos; 

	public float Intensivity;

	public static bool moveLeft,moveMiddle,moveRight=false;

	// Use this for initialization
	void Start () {
		PlayerPos = GameObject.Find("Player").transform.position;
		left = GameObject.Find("Left").transform.position;
		midlle = GameObject.Find("Midlle").transform.position;
		right = GameObject.Find("Right").transform.position;
		}
			
	// Update is called once per frame
	void Update () {
		if(Buttom_Color.invert==false){

		if (Input.GetKey(KeyCode.A)) moveLeft=true; 
		    if (moveLeft==true && transform.position!=left && moveMiddle==false && moveRight==false){ 
		        transform.position =  Vector3.Lerp(transform.position, left, Intensivity*Time.deltaTime);}
				else 
					moveLeft=false;
				 
		
		if (Input.GetKey(KeyCode.W)) moveMiddle=true;
		    if (moveMiddle==true && transform.position!=midlle && moveLeft==false && moveRight==false){
		        transform.position =  Vector3.Lerp(transform.position, midlle, Intensivity*Time.deltaTime);}
				else 
					moveMiddle=false;

		if (Input.GetKey(KeyCode.D)) moveRight=true;
		    if (moveRight==true && transform.position!=right && moveLeft==false && moveMiddle==false){
		        transform.position =  Vector3.Lerp(transform.position, right, Intensivity*Time.deltaTime);}
				else 
					moveRight=false;} 
					/// <summary>
					/// INVERTED CONTROL
					/// </summary>
					else {

		if (Input.GetKey(KeyCode.A))moveRight=true;
		    if (moveRight==true && transform.position!=right && moveLeft==false && moveMiddle==false){
		        transform.position =  Vector3.Lerp(transform.position, right, Intensivity*Time.deltaTime);}
				else 
					moveRight=false;
				 
		
		if (Input.GetKey(KeyCode.W)) moveMiddle=true;
		    if (moveMiddle==true && transform.position!=midlle && moveLeft==false && moveRight==false){
		        transform.position =  Vector3.Lerp(transform.position, midlle, Intensivity*Time.deltaTime);}
				else 
					moveMiddle=false;

		if (Input.GetKey(KeyCode.D))  moveLeft=true; 
		    if (moveLeft==true && transform.position!=left && moveMiddle==false && moveRight==false){ 
		        transform.position =  Vector3.Lerp(transform.position, left, Intensivity*Time.deltaTime);}
				else 
					moveLeft=false;
					}

					
	}

}

