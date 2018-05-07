using UnityEngine;
using System;
public class Delete : MonoBehaviour {

    public GameObject a;
    public GameObject b;
    public GameObject c;
	public static int Del;


    //  public GameObject d;
    // Use this for initialization
    // Update is called once per frame

	void Start()
	{
		

		}
     void Update()
	{
		
		Debug.Log (Del);
		if (Del >= 3) {
			Destroy (a);
			Destroy (b);
			Destroy (c);
			Destroy (this);
		}
	}

}
