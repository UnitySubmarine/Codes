using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    
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
                if (clickedobject.name == "Kitchen")
                {
                    SceneManager.LoadScene("kitchen");
                }
                if (clickedobject.name == "Cockpit")
                {
                    SceneManager.LoadScene("Cockpit");
                }
                if (clickedobject.name == "Engine")
                {
                    SceneManager.LoadScene("Engine");
                }
                if (clickedobject.name == "Exit")
                {
                    SceneManager.LoadScene("Exit");
                }
                if (clickedobject.name == "Title")
                {
                    SceneManager.LoadScene("Title");
                }
                if (clickedobject.name == "Crew_room")
                {
                    SceneManager.LoadScene("Crew_room");
                }
            }
        }
    }

    
}
