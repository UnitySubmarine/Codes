using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Inventory : MonoBehaviour
{
    public bool visible;
    public static Inventory instance = null;
    public Dictionary<string, bool> k = new Dictionary<string, bool>();
    void Start()
    {
        visible = false;
        SetVisibility(visible);
        if (instance == null) instance = this;
        else if (instance != this) Destroy(gameObject);
        DontDestroyOnLoad(gameObject);
        k.Add("Crowbar", false);
        k.Add("Driver", false);
        k.Add("Trans", false);
        k.Add("Recipe", false);
        k.Add("Nail", false);
        k.Add("Valve", false);
        k.Add("Flash", false);
        k.Add("Cable", false);
        k.Add("Plate", false);
        k.Add("Tape", false);
        k.Add("KeyforLocker", false);
        k.Add("KeyforKitchen", false);
    }
    
    void Update()
    {
        
    }

    public void clicked()
    {
        visible = !visible;
        SetVisibility(visible);
    }
    private void SetVisibility(bool isVisible)
    {
        GetComponent<PolygonCollider2D>().enabled = isVisible;
        GetComponent<Renderer>().enabled = isVisible;
    }
}
