using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle_Event : MonoBehaviour {
    public bool status = false; //входные д
    public GameObject Parent;
    public int i;
    private GameObject Player;

    private bool stat; //выходные д
    private GameObject Lines;


    // Use this for initialization
    void Start () {

        Player = GameObject.Find("Player");
    }
	
	// Update is called once per frame
	void Update () {
        stat = Player.GetComponent<Colorizing>().True_stat;
        if (stat == true)
        {
            Open();
            Debug.Log("Puzzle_Event: " + stat);
        }
	}

    void Open() {
        Lines = Parent.transform.Find("Line_mass").gameObject;
        Parent.GetComponent<Puzzle_Event>().enabled=true;
        if (Lines != null) {
            Lines.SetActive(true);
        }
        GetComponent<Puzzle_Event>().enabled = false;

    }
}
