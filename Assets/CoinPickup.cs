using System;
using UnityEngine;
using UnityEngine.AI;

public class CoinPickup : MonoBehaviour
{

    public NavMeshAgent agent;
    GameObject player;
    
    
    void Start()
    {
        player = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.back, Space.World);
        
        agent.SetDestination(player.transform.position);
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Bullet") || (other.gameObject.CompareTag("Player"))) 
        {
            Destroy(gameObject);
            RoomaManager700Script.instance.kills += 1;
        }
    }
}
