using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotation : MonoBehaviour {
    private GameObject _gameObg;
    public float speed_rot = 3f;
    
	// Use this for initialization
	void Start () {
        _gameObg = GetComponent<GameObject>();
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(Vector3.up * speed_rot * Time.deltaTime);
    }
}
