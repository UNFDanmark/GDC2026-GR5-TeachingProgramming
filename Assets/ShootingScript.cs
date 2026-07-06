using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class ShootingScript : MonoBehaviour
{
    public GameObject bulletPrefab;
    public InputAction shoot;
    public GameObject point;
    public float ballShooterCooldown = 0.5f;
    float cooldownLeft;
    public float power = 2000;
    public Animator animation;
    public AudioSource AudioSource;
    
    void Start()
    {
        shoot.Enable();
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update()
    {
        cooldownLeft = cooldownLeft - Time.deltaTime;

        if (shoot.WasPerformedThisFrame() && cooldownLeft <= 0)
        { 
            cooldownLeft = ballShooterCooldown;
            
            GameObject bullet = Instantiate(bulletPrefab, point.transform.position, Quaternion.identity);
            bullet.GetComponent<Rigidbody>().AddForce(transform.forward * power);
            animation.SetTrigger("Shoot");
            
        }
    }
}
