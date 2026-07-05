using UnityEngine;

public class BullletPuff : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void OnCollisionEnter(Collision other)
    {
        if (!other.gameObject.CompareTag("Player") )
        {
            Destroy(gameObject);
            
        }
    }
}
