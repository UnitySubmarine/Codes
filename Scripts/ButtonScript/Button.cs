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
                GameObject events = GameObject.Find("Inventory");
                if (clickedobject.name == "Kitchen")
                {
                    if(events.GetComponent<Inventory>().k["Crowbar"] == false) Debug.Log("door to kitchen is locked");
                    else{
                        events.GetComponent<Inventory>().visible = true;
                        events.GetComponent<Inventory>().clicked();
                        SceneManager.LoadScene("kitchen");
                    }
                }
                if (clickedobject.name == "Cockpit")
                {
                        events.GetComponent<Inventory>().visible = true;
                        events.GetComponent<Inventory>().clicked();
                        SceneManager.LoadScene("Cockpit");
                    
                }
                if (clickedobject.name == "Engine")
                {
                    if(events.GetComponent<Inventory>().k["Flash"] == false) Debug.Log("you cannot go to Engine without light");
                    else
                    {
                        events.GetComponent<Inventory>().visible = true;
                        events.GetComponent<Inventory>().clicked();
                        SceneManager.LoadScene("Engine");
                    }
                }
                if (clickedobject.name == "Exit")
                {
                    if(events.GetComponent<Eventhandler>().Exit == 0) Debug.Log("wait wait");
                    else
                    {
                        events.GetComponent<Inventory>().visible = true;
                        events.GetComponent<Inventory>().clicked();
                        SceneManager.LoadScene("Exit");
                    }
                }
                if (clickedobject.name == "Title")
                {
                    events.GetComponent<Inventory>().visible = true;
                    events.GetComponent<Inventory>().clicked();
                    SceneManager.LoadScene("Title");
                }
                if (clickedobject.name == "Crew_room")
                {
                    events.GetComponent<Inventory>().visible = true;
                    events.GetComponent<Inventory>().clicked();
                    SceneManager.LoadScene("Crew_room");
                }
            }
        }
    }

    
}
