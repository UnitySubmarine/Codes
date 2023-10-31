using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Background : MonoBehaviour
{
    public Dictionary<string, string[]> sceneobjects = new Dictionary<string, string[]>();
    public string[] Crew_room = {"Flash", "Tape", "Recipe", "Driver" };
    public string[] Engine = {"Crowbar"};
    public string[] kitchen = {"Nail", "Cable", "Plate", "Trans"};
    public string[] Cockpit = {"Valve"};
    void Start()
    {
        sceneobjects.Add("Crew_room", Crew_room);
        sceneobjects.Add("Engine", Engine);
        sceneobjects.Add("kitchen", kitchen);
        sceneobjects.Add("Cockpit", Cockpit);

        GameObject obj = GameObject.Find("Inventory");
        Scene thisname = SceneManager.GetActiveScene();
        for (int i = 0; i < sceneobjects[thisname.name].Length; i++)
        {
            if (obj.GetComponent<Inventory>().k[sceneobjects[thisname.name][i]] == true)
            {
                GameObject undead = GameObject.Find(sceneobjects[thisname.name][i]);
                undead.GetComponent<Renderer>().enabled = false;
                undead.GetComponent<PolygonCollider2D>().enabled = false;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
