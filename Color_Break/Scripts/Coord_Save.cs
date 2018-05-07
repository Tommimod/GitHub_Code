using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coord_Save : MonoBehaviour {
    public static Vector3 Koord;
    private GameObject Player;
    // Use this for initialization
    void Start () {
        Player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider coll) {
        if (coll.transform.CompareTag("Player"))
            Koord = new Vector3(Player.transform.position.x, Player.transform.position.y, Player.transform.position.z);
        Debug.Log(Koord);
    }
}
