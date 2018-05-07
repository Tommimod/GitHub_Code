using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump_bl : MonoBehaviour {
    float bounceAmount = 10;
    bool bounce = false;
    public Transform Player;
    void Start()
    {
        Player = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void onTriggerEnter(Collider other)
    {
        
            Player.position = Vector3.up * bounceAmount;
        
        
    }
}
