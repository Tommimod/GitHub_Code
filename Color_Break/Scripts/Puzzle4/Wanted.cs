using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Wanted : MonoBehaviour
{

    public string level;
    // private GameObject Player;



    // Use this for initialization
    void Start()
    {
        // Player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {


    }

    void OnTriggerEnter(Collider coll)
    {
        if (coll.transform.CompareTag("Player"))
        {
            GameManager.levelName = level;
            SceneManager.LoadScene("Loading");
        }
    }
}