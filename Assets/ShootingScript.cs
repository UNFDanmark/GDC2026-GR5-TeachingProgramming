using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class ShootingScript : MonoBehaviour
{
    public Rigidbody bulletPrefab;
    public InputAction shoot;
    public GameObject point;
    public float ballShooterCooldown = 0.5f;
    float cooldownLeft;
    
    void Start()
    {
        shoot.Enable();
    }

    void Update()
    {
        cooldownLeft = cooldownLeft - Time.deltaTime;

        if (shoot.WasPerformedThisFrame() && cooldownLeft <= 0)
        { 
            Instantiate(bulletPrefab, point.transform.position, Quaternion.identity);
            cooldownLeft = ballShooterCooldown;
        }
    }
}
