using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kursor : MonoBehaviour
{
    private Camera _camera;
    // Use this for initialization
    void Start()
    {
        _camera = GetComponent<Camera>();
        Cursor.lockState = CursorLockMode.Locked;
    }
}