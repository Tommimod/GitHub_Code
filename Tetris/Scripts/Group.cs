using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Group : MonoBehaviour {
	float lastFall = 0;
	float TimeFall = 1;
	public bool dead = false;
	private AudioClip din;
    AudioSource sound;


	// Use this for initialization
	public void Start() {
		
		// Default position not valid? Then it's game over
		if (!isValidGridPos()) {
			Destroy(gameObject);
			dead = true;
			GameObject.Find("EventSystem").GetComponent<Dead>().DeadMenu();
			dead = false;
			
		}
	}
	public void SoundFall(){
		sound = GetComponent<AudioSource>();
		din =Resources.Load("fall") as AudioClip;
		sound.PlayOneShot(din);
	}

	public void SoundDelete(){
		sound = GetComponent<AudioSource>();
		din =Resources.Load("defoll") as AudioClip;
		sound.PlayOneShot(din);
	}
	// Update is called once per frame
	void Update() {
    if(Grid.Count>20) TimeFall=0.9f; 
	if(Grid.Count>50) TimeFall=0.8f;
	if(Grid.Count>80) TimeFall=0.7f;
	if(Grid.Count>100) TimeFall=0.6f;
	if(Grid.Count>120) TimeFall=0.5f;
	if(Grid.Count>160) TimeFall=0.5f;
	if(Grid.Count>190) TimeFall=0.4f;
	if(Grid.Count>240) TimeFall=0.3f;
 
		// Move Left
		if (Input.GetKeyDown(KeyCode.LeftArrow)) {
			// Modify position
			transform.position += new Vector3(-1, 0, 0);

			// See if valid
			if (isValidGridPos())
				// It's valid. Update grid.
				updateGrid();
			else
				// It's not valid. revert.
				transform.position += new Vector3(1, 0, 0);
		}
		

		// Move Right
		else if (Input.GetKeyDown(KeyCode.RightArrow)) {
			// Modify position
			transform.position += new Vector3(1, 0, 0);

			// See if valid
			if (isValidGridPos())
				// It's valid. Update grid.
				updateGrid();
			else
				// It's not valid. revert.
				transform.position += new Vector3(-1, 0, 0);
		}

		// Rotate
		else if (Input.GetKeyDown(KeyCode.UpArrow)) {
			transform.Rotate(0, 0, -90);

			// See if valid
			if (isValidGridPos())
				// It's valid. Update grid.
				updateGrid();
			else
				// It's not valid. revert.
				transform.Rotate(0, 0, 90);
		}

		// Move Downwards and Fall
		else if (Input.GetKeyDown(KeyCode.DownArrow) ||
			Time.time - lastFall >= TimeFall) {
				
			// Modify position
			transform.position += new Vector3(0, -1, 0);

			// See if valid
			if (isValidGridPos()) {
				// It's valid. Update grid.
				updateGrid();
			} else {
				// It's not valid. revert.
				transform.position += new Vector3(0, 1, 0);

				// Clear filled horizontal lines
				Grid.deleteFullRows();

				SoundFall();

				// Spawn next Group
				FindObjectOfType<Spawner>().spawnNext();

				// Disable script
				enabled = false;

				
			}

			lastFall = Time.time;
		}
	}

	bool isValidGridPos() {        
		foreach (Transform child in transform) {
			Vector2 v = Grid.roundVec2(child.position);

			// Not inside Border?
			if (!Grid.insideBorder(v))
				return false;

			// Block in grid cell (and not part of same group)?
			if (Grid.grid[(int)v.x, (int)v.y] != null &&
				Grid.grid[(int)v.x, (int)v.y].parent != transform)
				return false;
		}
		return true;
	}

	void updateGrid() {
		// Remove old children from grid
		for (int y = 0; y < Grid.h; ++y)
			for (int x = 0; x < Grid.w; ++x)
				if (Grid.grid[x, y] != null)
				if (Grid.grid[x, y].parent == transform)
					Grid.grid[x, y] = null;

		// Add new children to grid
		foreach (Transform child in transform) {
			Vector2 v = Grid.roundVec2(child.position);
			Grid.grid[(int)v.x, (int)v.y] = child;
		}        
	}
}
