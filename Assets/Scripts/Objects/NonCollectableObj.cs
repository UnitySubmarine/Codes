using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NonCollectableObj : MonoBehaviour
{
    private Obj objectsetting;
    void Start()
    {
        objectsetting = GetComponent<Obj>();
        objectsetting.IsCollectable = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
