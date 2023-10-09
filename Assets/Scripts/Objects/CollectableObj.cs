using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;

public class CollectableObj : MonoBehaviour
{
    private Obj objectsetting;
    private int IsOnMyInventory;
    void Start()
    {
        objectsetting = GetComponent<Obj>();
        objectsetting.IsCollectable = 1;
        IsOnMyInventory = 0;
    }
    
    void Update()
    {
        
    }

    public void clicked()
    {
        if (IsOnMyInventory == 0)
        {
            IsOnMyInventory = 1;
            this.GetComponent<PolygonCollider2D>().enabled = false;
            this.GetComponent<Renderer>().enabled = false;
            Debug.Log("you've got this object - " + this.name);
        }
    }
}
