using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuContrl : MonoBehaviour {
   public AudioClip din;
    AudioSource sound;
	public GameObject MenuButtons;
	public GameObject Really;

	// Use this for initialization
	void Start () {
		sound = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void ShowReally(){
		sound.PlayOneShot(din);
        MenuButtons.SetActive(false);
		Really.SetActive(true);

	}

	public void ShowMenu(){
		sound.PlayOneShot(din);
        MenuButtons.SetActive(true);
		Really.SetActive(false);

	}

	public void ExitGame(){
		sound.PlayOneShot(din);
		Application.Quit();
	}

	public void LoadGame(){
		sound.PlayOneShot(din);
		Application.LoadLevel("Game");
	}

	
}
