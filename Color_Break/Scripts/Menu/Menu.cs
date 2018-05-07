using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {
    private GameObject kursor;
    private GameObject Player;
    private GameObject Camera;
    private GameObject KRS;
    private GameObject Menus;
    private GameObject nastroi;

    private GameObject destr;
    public string level;
    public bool pause_p;
    // Use this for initialization
    void Start()
    {
        kursor = GameObject.Find("Cursr");
        Player = GameObject.Find("Player");
        Camera = GameObject.Find("Main Camera");
        KRS = GameObject.Find("KRS");
        Menus = KRS.transform.Find("Menus").gameObject;
        nastroi = KRS.transform.Find("Nastroiki").gameObject;
     //   destr = GameObject.Find("Destroyer");
    }
    // Update is called once per frame
    public void NewGame() {

    

        GameManager.levelName = level;
        SceneManager.LoadScene("Loading");
       

    }

    public void Prod()
    {
        Time.timeScale = 1;
        Cursor.lockState = CursorLockMode.Locked;
        kursor.SetActive(true);
        Player.GetComponent<MouseLook>().enabled = true;
        Camera.GetComponent<MouseLook>().enabled = true;
        Menus.SetActive(false);
        nastroi.SetActive(false);
        pause_p = true;
        pause_p = false;
    }
    public void Nactr() {
        Menus.SetActive(false);
        nastroi.SetActive(true);
    }

    public void Nazad()
    {
        Menus.SetActive(true);
        nastroi.SetActive(false);
    }

    public void ExMenu() {
        GameManager.levelName = "Main_Menu";
        SceneManager.LoadScene("Loading");
    }

    public void ExGame() {
        Application.Quit();
    }

    }

    

