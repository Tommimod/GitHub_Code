using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Grid : MonoBehaviour {
	Group dead;
	
static Sprite newcolor;
static Sprite oldcolor;
	 public static int Count = 0;
      static GameObject[] mass_prefabs = new GameObject[7]; //префабы
	  static Sprite[] colors = new Sprite[6]; // цвета кубов
	public static int w = 10;
	public static int h = 20;
	public static Transform[,] grid = new Transform[w, h];
	// Use this for initialization
	void Awake () {
		mass_prefabs[0]= Resources.Load("Groap_A") as GameObject;
		mass_prefabs[1]= Resources.Load("Groap_B") as GameObject;
		mass_prefabs[2]= Resources.Load("Groap_C") as GameObject;
		mass_prefabs[3]= Resources.Load("Groap_D") as GameObject;
		mass_prefabs[4]= Resources.Load("Groap_E") as GameObject;
		mass_prefabs[5]= Resources.Load("Groap_F") as GameObject;
		mass_prefabs[6]= Resources.Load("Groap_G") as GameObject;

	    colors[0] = Instantiate (Resources.Load ("blue", typeof(Sprite))) as Sprite;
		colors[1] = Instantiate (Resources.Load ("green", typeof(Sprite))) as Sprite;
		colors[2] = Instantiate (Resources.Load ("orange", typeof(Sprite))) as Sprite;
		colors[3] = Instantiate (Resources.Load ("yellow", typeof(Sprite))) as Sprite;
		colors[4] = Instantiate (Resources.Load ("red", typeof(Sprite))) as Sprite;
		colors[5] = Instantiate (Resources.Load ("sky", typeof(Sprite))) as Sprite;

			ChangeColors();

	}

	public static void Zero(){
		Count = 0;
	}
	public static Vector2 roundVec2(Vector2 v) {
		return new Vector2(Mathf.Round(v.x),
			Mathf.Round(v.y));
	}

	public static void deleteRow(int y) {
		for (int x = 0; x < w; ++x) {
			Destroy(grid[x, y].gameObject);
			grid[x, y] = null;
		}
	}

	public static bool insideBorder(Vector2 pos) {
		return ((int)pos.x >= 0 &&
			(int)pos.x < w &&
			(int)pos.y >= 0);
	}

	public static void decreaseRow(int y) {
		for (int x = 0; x < w; ++x) {
			if (grid[x, y] != null) {
				// Move one towards bottom
				grid[x, y-1] = grid[x, y];
				grid[x, y] = null;

				// Update Block position
				grid[x, y-1].position += new Vector3(0, -1, 0);
			}
		}
	}

	public static void decreaseRowsAbove(int y) {
		for (int i = y; i < h; ++i)
			decreaseRow(i);
	}

	public static bool isRowFull(int y) {
		for (int x = 0; x < w; ++x)
			if (grid[x, y] == null)
				return false;
		return true;
	}
	public static int CountPlus (int Countу){
		Count+=10;
		GameObject.Find("Counts").GetComponent<Text>().text = Count.ToString();
		return Count;
				}

	public static void deleteFullRows() {
		for (int y = 0; y < h; ++y) {
			if (isRowFull(y)) {
				deleteRow(y);
				decreaseRowsAbove(y+1);
				CountPlus (0);
				ChangeColors();
				--y;

			}
		}
	}
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Cancel")) Application.LoadLevel("Menu");

		if (dead == true) {
			Count = 0;
			GameObject.Find("Counts").GetComponent<Text>().text = Count.ToString();
		}
	}
	public static void RandomColor(){
		while (oldcolor==newcolor) {
		 newcolor = colors[ Random.Range(0, colors.Length)];
		 }
		oldcolor=newcolor;
	}

	public static  void ChangeColors(){

		RandomColor();
				for (int i = 0; i<mass_prefabs.Length;i++){
			for(int a = 0; a<mass_prefabs[i].transform.childCount; a++) {
               mass_prefabs[i].transform.GetChild(a).GetComponent<SpriteRenderer>().sprite = newcolor;
                }
			}
		}
	}