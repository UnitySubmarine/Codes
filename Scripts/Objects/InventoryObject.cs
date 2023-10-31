using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryObject : MonoBehaviour
{
    public bool visible;
    private GameObject obj;
    public InventoryObject instance;
    private string realname;
    void Start()
    {
        this.visible = false;
        realname = this.name.Replace("_Inventory", "");
        obj = GameObject.Find("Inventory");
        if (instance == null) instance = this;
        else if (instance != this) Destroy(gameObject);
        DontDestroyOnLoad(gameObject);
    }
    void Update()
    {
        if (obj.GetComponent<Inventory>().k[realname] == true && obj.GetComponent<Inventory>().visible == true)
        {
            this.visible = true;
        }
        else
        {
            this.visible = false;
        }
        this.GetComponent<Renderer>().enabled = visible;
        this.GetComponent<PolygonCollider2D>().enabled = visible;
    }
}
