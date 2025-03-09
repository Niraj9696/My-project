using UnityEngine;

public class Findobject : MonoBehaviour
{
   
    void Start()
    {
        // Method 1: Find by Name
        GameObject objByName = GameObject.Find("CubeB");
        if (objByName != null)
        {
            Debug.Log("Found object by name: " + objByName.name);
        }
        else
        {
            Debug.Log("Object not found by name.");
        }

        // Method 2: Find by Tag
        GameObject objByTag = GameObject.FindWithTag("Ground");
        if (objByTag != null)
        {
            Debug.Log("Found object by tag: " + objByTag.name);
        }
        else
        {
            Debug.Log("Object not found by tag.");
        }
    }
}

