using UnityEngine;
using System.Collections;
[RequireComponent(typeof(CharacterController))]
[AddComponentMenu("Control Script/FPS Input")]
public class FPSInput : MonoBehaviour
{
    public int healht = 100;
    public float speed = 6.0f;
    public float gravity = -9.8f;
    public float jumpSpeed = 15.0f;
    public float terminalVelocity = -10.0f;
    public float minFall = -1.5f;
    public float pushPower = 2.0F;
    public float dist = 100f;

    private CharacterController _charController;
    private float _vertSpeed;
    private ControllerColliderHit _contact;

    void Start()
    {
        _vertSpeed = minFall;
        _charController = GetComponent<CharacterController>();
    }
    void Update()
    {
        if (healht > 100) { healht = 100; }
        if (healht <= 20) { speed = 2.5f; }
        if (healht <= 50) { speed = 4.5f; }
        if (healht > 50) { speed = 6.0f; }

        float deltaX = Input.GetAxis("Horizontal") * speed;
        float deltaZ = Input.GetAxis("Vertical") * speed;
        Vector3 movement = new Vector3(deltaX, 0, deltaZ);
        movement = Vector3.ClampMagnitude(movement, speed);
        movement.y = gravity;
        movement *= Time.deltaTime;
        movement = transform.TransformDirection(movement);
        _charController.Move(movement);
        //JUMP

        /*  bool hitGround = false;
          RaycastHit hit;
          if (_vertSpeed < 0 && Physics.Raycast(transform.position, Vector3.down, out hit))
          {
              float check = (_charController.height + _charController.radius) / 1.9f;
              hitGround = hit.distance <= check;
          }
          if (hitGround)
          {
              if (Input.GetButtonDown("Jump"))
              {
                  _vertSpeed = jumpSpeed;
              }
              else
              {
                  _vertSpeed = minFall;
              }
          }
          else
          {
              _vertSpeed += gravity * 5 * Time.deltaTime;
              if (_vertSpeed < terminalVelocity)
              {
                  _vertSpeed = terminalVelocity;
              }
              if (_charController.isGrounded)
              {
                  if (Vector3.Dot(movement, _contact.normal) < 0)
                  {
                      movement = _contact.normal * speed;
                  }
                  else
                  {
                      movement += _contact.normal * speed;
                  }
              }
          }
          movement.y = _vertSpeed;
          movement *= Time.deltaTime;
          _charController.Move(movement);

          Rigidbody body = GetComponent<Rigidbody>();
          Ray ray = new Ray(transform.position, Vector3.down);
          if (Physics.Raycast(ray, out hit, dist))
          {
              if (hit.collider.gameObject.tag == "J_B" || dist <= 1f)
              {
                  _charController.Move(Vector3.up / 2);
              }
              else if (dist > 5f) { _charController.Move(Vector3.zero); }
          }
      }

          void OnControllerColliderHit(ControllerColliderHit hit)
      { 
  _contact = hit;
          Rigidbody body = hit.collider.attachedRigidbody;
          if (body == null || body.isKinematic)
              return;

          if (hit.moveDirection.y < -0.3F)
              return;

          Vector3 pushDir = new Vector3(hit.moveDirection.x, 0, hit.moveDirection.z);
          body.velocity = pushDir * pushPower;
              }*/
    }
}
