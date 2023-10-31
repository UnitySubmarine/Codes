using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory_visible : MonoBehaviour
{
    public static Inventory_visible instance = null;
    void Start()
    {
        if (instance == null) instance = this;
        else if (instance != this) Destroy(gameObject);
        DontDestroyOnLoad(gameObject);
    }

    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(pos, Vector2.zero);
            if (hit.collider != null)
            {
                GameObject clickedobject = hit.transform.gameObject;
                if (clickedobject.name == this.name)
                {
                    GameObject obj;
                    obj = GameObject.FindWithTag("Inven");
                    obj.GetComponent<Inventory>().clicked();
                }
            }
        }
    }
}
