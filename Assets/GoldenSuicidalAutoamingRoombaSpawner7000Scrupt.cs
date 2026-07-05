using UnityEngine;

public class GoldenSuicidalAutoamingRoombaSpawner7000Scrupt : MonoBehaviour
{
    public GameObject GoldenSuicidalAutoamingRoomba;
    float cooldownLeft;
    float cooldown = 1;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        cooldownLeft -= Time.deltaTime;
        if (cooldownLeft <= 0)
        {
            Vector3 pos = transform.position;
            pos.x += Random.Range(-10, 10);
            pos.z += Random.Range(-10, 10);
            Instantiate(GoldenSuicidalAutoamingRoomba, pos, Quaternion.identity);
            cooldownLeft = cooldown;

        }
    }
}
