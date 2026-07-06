using System;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class EvilSpeech : MonoBehaviour
{
  public int speed = 10;
  Rigidbody rb;
  public InputAction moveAction;
  public int health = 3;
  public Animator animation;
  public InputAction turnAction;
  public Transform transformToMoveAbout;

  void Start()
  {
    moveAction.Enable();
    turnAction.Enable();
    rb = GetComponent<Rigidbody>();
  }

  void Update()
  {
    Vector2 moveInput = moveAction.ReadValue<Vector2>();

    Vector3 newVelocity = rb.linearVelocity;
    newVelocity.x = 0;
    newVelocity.z = 0;

    var newForward = transformToMoveAbout.forward * (moveInput.y * speed);
    var newRight = transformToMoveAbout.right * (moveInput.x * speed);
    newVelocity += newRight + newForward;

    
    rb.linearVelocity = newVelocity;
    animation.SetFloat("Speed", rb.linearVelocity.magnitude);
    
    
    if (speed > 8)
    {
      print(
        "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA!");
    }
    else
    {
      print("Lynet McNejjj...");
    }


    if (health <= 0)
    {
      Destroy(gameObject);
    }
  }
  
  void OnCollisionEnter(Collision other)
  {
    if (other.gameObject.CompareTag("Coin"))
    {
      health -= 1;
    }
  }
}
