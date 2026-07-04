using System;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class EvilSpeech : MonoBehaviour
{
  public int speed = 10;
  Rigidbody rb;
  public InputAction moveAction;


  void Start()
  {
    moveAction.Enable();
    rb = GetComponent<Rigidbody>();
  }

  void Update()
  {
    Vector2 moveInput = moveAction.ReadValue<Vector2>();

    Vector3 newVelocity = rb.linearVelocity;

    newVelocity.x = moveInput.x * speed;
    newVelocity.z = moveInput.y * speed;

    rb.linearVelocity = newVelocity;
    
    
    
    
    
    if (speed > 8)
    {
      print(
        "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA!");
    }
    else
    {
      print("Lynet McNejjj...");
    }
  }
}
