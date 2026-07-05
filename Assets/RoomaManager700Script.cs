using System;
using UnityEngine;

public class RoomaManager700Script : MonoBehaviour
{
    public static RoomaManager700Script instance;
    public int kills;
    void Start()
    {
        
    }


    void Update()
    {
        
    }

    void Awake()
    {
        if (instance != null)
        {
            Destroy(this);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(this);
        }
    }
}
