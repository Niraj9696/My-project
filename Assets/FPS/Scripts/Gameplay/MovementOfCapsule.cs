using UnityEngine;


public class MovementOfCapsule : MonoBehaviour
{
     public GameObject Capsule;
    private float speed = 2f;
    private float minY = 1f;
    private float maxY = 4f;
    private bool movingUp = true;
    // Update is called once per frame
    void Update()
    {
       float y = Capsule.transform.position.y;

        if (movingUp)
        {
            y += speed * Time.deltaTime ;
            if ( y >= maxY) movingUp = false ;
        }
        else
        {
            y -= speed * Time.deltaTime;
            if (y <= minY) movingUp = true ;
        }
        Capsule.transform.position = new Vector3(4.51f, y, 11.78f);
    }
}
