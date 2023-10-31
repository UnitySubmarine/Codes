using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eventhandler : MonoBehaviour
{
    public int Cockpit = 1;
    public int Engine = 0;
    public int Exit = 0;
    public int kitchen = 0;
    public static Eventhandler instance = null;
    void Start()
    {
        if (instance == null) instance = this;
        else if (instance != this) Destroy(gameObject);
        DontDestroyOnLoad(gameObject);
    }
    void Update()
    {
        
    }
}
