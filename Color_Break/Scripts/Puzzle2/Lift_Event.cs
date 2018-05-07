using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lift_Event : MonoBehaviour
{
    private new Camera camera;
    private GameObject a;
    private GameObject Lift;
    // Use this for initialization
    void Start()
    {
        Lift = GameObject.Find("Lift");
        camera = GameObject.Find("Main Camera").GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {

        Ray ray = Camera.main.ScreenPointToRay(new Vector3(camera.pixelWidth / 2, camera.pixelHeight / 2, 0));
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, 5))
        {
            if (hit.collider.gameObject.tag == "LiftUP" || hit.collider.gameObject.tag == "LiftDown")
            {
                if (Input.GetButtonDown("Fire1"))
                {
                    a = hit.collider.gameObject;
                    if (a.tag == "LiftUP")
                    {
                        Lift.GetComponent<Lift_UP>().enabled = true;
                    }

                    if (a.tag == "LiftDown")
                    {
                        Lift.GetComponent<Lift_DW>().enabled = true;
                    }
                }
            }
        }
    }

}
