using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Panel_fall : MonoBehaviour
{
    public Material yellow;
    private GameObject Player;

    private GameObject a;
    private MeshRenderer rend;
    // Use this for initialization
    void Start()
    {
        Player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
  
        RaycastHit hit;

        if (Physics.Raycast(Player.transform.position, Vector3.down, out hit))
        {
            if (hit.collider.gameObject.tag == "Line+" || hit.collider.gameObject.tag == "Line-")
            {
                a = hit.collider.gameObject;
                rend = a.GetComponent<MeshRenderer>();
                //правильно
                if (a.tag == "Line+")
                {
                    rend.material = yellow;

                }
                else if (a.tag == "Line-")
                {
                    a.SetActive(false);

                }
            }
        }
    }
}