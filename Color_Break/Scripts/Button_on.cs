﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button_on : MonoBehaviour {
    public GameObject[] GO;
    // Use this for initialization
    void Start () {
      
    }

    // Update is called once per frame
    private void OnMouseDown()
    {
        foreach (GameObject element in GO)
        {
            element.SetActive(true);
        }
    }
}
