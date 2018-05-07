using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colorizing : MonoBehaviour {
    public Material yellow;
    public Material white;
    private new Camera camera;
    public GameObject Puzzle_close;
    public bool True_stat;

    private SpriteRenderer rend;
    private GameObject a;
    private int win;
    private bool stat;
    private int i;
    // Use this for initialization
    void Start () {
        win = 0;
        camera = GameObject.Find("Main Camera").GetComponent<Camera>();
    }
	
	// Update is called once per frame
	void Update () {

        True_stat = false;
        Ray ray = Camera.main.ScreenPointToRay(new Vector3(camera.pixelWidth / 2, camera.pixelHeight / 2, 0));
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, 5))
        {
            if (hit.collider.gameObject.tag == "Window")
            { Puzzle_close = hit.collider.gameObject; }
        }

        stat = Puzzle_close.GetComponent<Puzzle_Event>().status;
        i = Puzzle_close.GetComponent<Puzzle_Event>().i;
    

                if (Physics.Raycast(ray, out hit, 5))
        {
            if (hit.collider.gameObject.tag == "Line+" || hit.collider.gameObject.tag == "Line-" || hit.collider.gameObject.tag == "Line++" || hit.collider.gameObject.tag == "Line--")
            {
                if (Input.GetButtonDown("Fire1"))
                {
                    a = hit.collider.gameObject;
                    rend = a.GetComponent<SpriteRenderer>();
                    //правильно
                    if (a.tag == "Line+")
                    { 
                            win = win + 1;
                            rend.material = yellow;
                            a.tag = "Line-";
                        
                    }
                    else if (a.tag == "Line-")
                    {
                        win = win - 1;
                        rend.material = white;
                        a.tag = "Line+";
                    }
                    //неправильно
                    if (a.tag == "Line++")
                    {
                        win = win - 1;
                        rend.material = yellow;
                        a.tag = "Line--";
                    }
                    else if (a.tag == "Line--")
                    {
                        win = win + 1;
                        rend.material = white;
                        a.tag = "Line++";
                    }
                    if (win == i)
                    {
                        stat = true;
                        win = 0;
                        True_stat = stat;
                       

                        Debug.Log(True_stat);
                        Debug.Log(win);
                        Debug.Log(i);
                    }
                }
            }
        }


    }
}
