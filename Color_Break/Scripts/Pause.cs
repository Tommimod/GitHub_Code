using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public bool _pause = false;
    private Menu pause_p;
    private GameObject kursor;
    private GameObject Player;
    private GameObject Camera;
    private GameObject KRS;
    private GameObject Menus;
    private GameObject nastroi;
    // Use this for initialization
    void Start()
    {
        kursor = GameObject.Find("Cursr");
        Player = GameObject.Find("Player");
        Camera = GameObject.Find("Main Camera");
        KRS = GameObject.Find("KRS");
        Menus = KRS.transform.Find("Menus").gameObject;
        nastroi = KRS.transform.Find("Nastroiki").gameObject;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyUp(KeyCode.Escape))
         {
         
            if (_pause==false)
            {
                Time.timeScale = 0;
                _pause = true;
                Cursor.lockState = CursorLockMode.None;
                kursor.SetActive(false);
                Player.GetComponent<MouseLook>().enabled = false;
                Camera.GetComponent<MouseLook>().enabled = false;
                Menus.SetActive(true);
            }
          else if (_pause == true)
            {
                Time.timeScale = 1;
                _pause = false;
                _pause = pause_p;
                Cursor.lockState = CursorLockMode.Locked;
                kursor.SetActive(true);
                Player.GetComponent<MouseLook>().enabled = true;
                Camera.GetComponent<MouseLook>().enabled = true;
                Menus.SetActive(false);
                nastroi.SetActive(false);
            }
        }
    }
}
