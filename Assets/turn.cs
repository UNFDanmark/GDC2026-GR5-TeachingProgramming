using UnityEngine;
using UnityEngine.InputSystem;

public class turn : MonoBehaviour
{
    public InputAction turnAction;
    public float sens;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        turnAction.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        float turnInput = turnAction.ReadValue<float>();
        transform.Rotate(0,turnInput*sens, 0, Space.World);

    }
}
