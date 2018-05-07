using UnityEngine;

public class Activate_red : MonoBehaviour {
    public bool red=false;
    public GameObject des_light;
    private new Camera camera;
    // Use this for initialization
    void Start () {
        camera = GameObject.Find("Main Camera").GetComponent<Camera>();
    }
	
	// Update is called once per frame
	void Update () {

        Ray ray = Camera.main.ScreenPointToRay(new Vector3(camera.pixelWidth / 2, camera.pixelHeight / 2, 0));
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, 5))
        {
            if (hit.collider.gameObject.name== "lever_r")
            {
                if (Input.GetButtonDown("Fire1"))
                {
                   
                    des_light.SetActive(true);
                    Debug.Log(red);
                }
            }
        }
    }
    private void OnMouseDown()
    {
      
    }
}
