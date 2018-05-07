using UnityEngine;

public class Ev_Color : MonoBehaviour {
    private GameObject Color;
    private GameObject Red;
    private GameObject Orange;
    private GameObject Yellow;
    private GameObject Green;
    private GameObject Sini;
    private  Camera ccamera;

    public bool red=false;
    public bool O_b = false;
    public bool Y_b = false;
    public bool G_b = false;
    public bool S_b = false;

    public Light L_2;
    public Light L_3;
    public Light L_4;
    public Light L_5;

    // Use this for initialization
    public void Start () {
        Color = GameObject.Find("Color");
        Red = Color.transform.Find("RED").gameObject;
        Orange = Color.transform.Find("Orange").gameObject;
        Yellow = Color.transform.Find("Yellow").gameObject;
        Green = Color.transform.Find("Green").gameObject;
        Sini = Color.transform.Find("Sini").gameObject;
        ccamera = GameObject.Find("Main Camera").GetComponent<Camera>();
        

            }

    // Update is called once per frame
    void Update () {
        Red.SetActive(red);
        Orange.SetActive(O_b);
        Yellow.SetActive(Y_b);
        Green.SetActive(G_b);
        Sini.SetActive(S_b);

        Ray ray = Camera.main.ScreenPointToRay(new Vector3(ccamera.pixelWidth / 2, ccamera.pixelHeight / 2, 0));
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, 5))
        {
            if (hit.collider.gameObject.name == "lever_r")
            {
                if (Input.GetButtonDown("Fire1"))
                {
                    red = true;
                    L_2.GetComponent<Light>().enabled = true;
                }
            }
        }

    }

}
