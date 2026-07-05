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
    
    void Start()
    {
        shoot.Enable();
    }

    void Update()
    {
        cooldownLeft = cooldownLeft - Time.deltaTime;

        if (shoot.WasPerformedThisFrame() && cooldownLeft <= 0)
        { 
            cooldownLeft = ballShooterCooldown;
            
            GameObject bullet = Instantiate(bulletPrefab, point.transform.position, Quaternion.identity);
            bullet.GetComponent<Rigidbody>().AddForce(Vector3.forward*power);
        }
    }
}
