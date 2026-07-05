using System;
using UnityEngine;

public class pewpew : MonoBehaviour
{
    bool hitSomething;
    RaycastHit hit;

    public float renderDistance = 8f;
    public Transform eyes;
    
    public GameObject bulletPrefab;
    public GameObject point;
    public float ballShooterCooldown = 0.5f;
    float cooldownLeft;
    public float power = 2000;

    void Update()
    {
        hitSomething = Physics.Raycast(eyes.position, eyes.forward,out hit, renderDistance);
        cooldownLeft = cooldownLeft - Time.deltaTime;
        
        if (hitSomething)
        {
            if (hit.transform.CompareTag("Player"))
            {
                cooldownLeft = ballShooterCooldown;
            
                GameObject bullet = Instantiate(bulletPrefab, point.transform.position, Quaternion.identity);
                bullet.GetComponent<Rigidbody>().AddForce(Vector3.forward*power);
            }
            
        }
        
        
        
        
    }

    void OnDrawGizmos()
    {
        if (hitSomething && hit.transform.CompareTag("Player"))
        {
            Gizmos.color = Color.green;
        }
        else
        {
            Gizmos.color = Color.red;
        }
        Gizmos.DrawRay(eyes.position,eyes.forward*renderDistance);
    }
}
