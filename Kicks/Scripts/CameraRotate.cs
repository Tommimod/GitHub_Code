using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotate : MonoBehaviour {
public enum RotationAxes {
MouseXAndY = 0,
MouseX = 1,
MouseY = 2
}
public RotationAxes axes = RotationAxes.MouseXAndY;
public float sensitivityHor = 9.0f;
private float _rotationX = 0;
private GameObject Player;
void Start() {
Cursor.visible=false;
Player = GameObject.Find("Player");
}
void Update() {
if (axes == RotationAxes.MouseX) {
transform.Rotate(0, 0, Input.GetAxis("Mouse X") * sensitivityHor);

}
}
}
