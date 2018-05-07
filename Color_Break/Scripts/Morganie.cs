using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Morganie : MonoBehaviour {
    public Light lgt;
    public GameObject Trigger;
    private bool i;
	// Use this for initialization
	void Start () {
        i = true;
        StartCoroutine(Do());
    }

    // Update is called once per frame
    IEnumerator Do()
    {
        do
        {
           
            lgt.enabled = false;
            Trigger.SetActive(false);
            yield return new WaitForSeconds(3);
            lgt.enabled = true;
            Trigger.SetActive(true);
            yield return new WaitForSeconds(1);
            
            yield return new WaitForSeconds(1);
        } while (i == true);
        
    }
    void Update()
    {
        

    }
}
