using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obj : MonoBehaviour
{
    public int IsCollectable = 0;

    void Start()
    {

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
                    if (IsCollectable == 1)
                    {
                        Debug.Log("Player got " + clickedobject.name);
                        clickedobject.GetComponent<CollectableObj>().clicked();
                    }
                    else Debug.Log("Player clicked " + clickedobject.name);
                }
            }


        }
    }
}
