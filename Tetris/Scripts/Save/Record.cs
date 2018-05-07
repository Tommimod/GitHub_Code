using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Record : MonoBehaviour {
      public int _record;
	  public Text label;
	// Use this for initialization
	void Start () {
		
	}
	// Update is called once per frame
	void Update () {
		if (Grid.Count>_record){
			PlayerPrefs.SetInt("score", Grid.Count);
			PlayerPrefs.Save();
		}
	   _record = PlayerPrefs.GetInt("score");
	  label.text = _record.ToString();

	}
}
