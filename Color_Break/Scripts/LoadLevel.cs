using UnityEngine;
using UnityEngine.SceneManagement;
using System;
public class LoadLevel : MonoBehaviour {

    public string level;
    private GameObject ev;
    private GameObject Color;
    private GameObject Player;
    private GameObject KRS;
    private Vector3 Koord;
    private Vector3 P1;
    private GameObject destr;
    private GameObject Doors;


    // Use this for initialization
    void Start () {
        ev = GameObject.Find("Color");
        Player = GameObject.Find("Player");
        KRS = GameObject.Find("KRS");

        Doors = GameObject.Find("DoorMas");
    }
	
	// Update is called once per frame
	void Update () {

    }

    void OnTriggerEnter(Collider coll)
    {
        if (coll.transform.CompareTag("Player"))
        {

            GameObject[] dmass = GameObject.FindGameObjectsWithTag("Doors");
            if (dmass.Length > 2) Destroy(Doors.gameObject);
            DontDestroyOnLoad(Doors.gameObject);

            GameObject[] mass = GameObject.FindGameObjectsWithTag("Finish");
            if (mass.Length > 2) Destroy(KRS.gameObject);
            DontDestroyOnLoad(KRS.gameObject);

            GameObject[] pl = GameObject.FindGameObjectsWithTag("Player");
            if (pl.Length > 2) Destroy(Player.gameObject);
            DontDestroyOnLoad(Player.gameObject);

            GameObject[] objs = GameObject.FindGameObjectsWithTag("Color");
            if (objs.Length > 2) Destroy(ev.gameObject);
            DontDestroyOnLoad(ev.gameObject);

            GameManager.levelName = level;
            SceneManager.LoadScene("Loading");

            Player.GetComponent<GameObject>();
            if (level == "1_scene")
            {
                
                destr = GameObject.Find("Destroyer");
                Koord = new Vector3(-108, 4, -21);
                Player.transform.position = Koord;
               // destr.GetComponent<Delete>().OnLevelWasLoaded(1);
            }
        
            if (level == "Puzzle_1")
            {
                P1 = new Vector3(24, 11, -39);
                Player.transform.position = P1;
            }
        }
    }

 
}
