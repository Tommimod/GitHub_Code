using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lift_DW : MonoBehaviour {
    private Transform Lift;
    public float speed = 2;
    // Use this for initialization
    void Start()
    {
        Lift = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(Down());
    }

    IEnumerator Down()
    {

        Lift.transform.Translate(new Vector3(0, -1, 0).normalized * Time.deltaTime * speed);
        yield return new WaitForSeconds(2);
        GetComponent<Lift_DW>().enabled = false;
    }
}