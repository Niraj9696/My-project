using UnityEngine;

public class BoxColor : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
   
        {
            GameObject[] Boxes = GameObject.FindGameObjectsWithTag("Box");
            foreach (GameObject Box in Boxes)
            {
                Box.GetComponent<MeshRenderer>().material.color = Color.blue;
            }
        }


    // Update is called once per frame
    void Update()
    {
        
    }
}
