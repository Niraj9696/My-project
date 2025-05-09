using UnityEngine;

public class MovingTrap : Trap
{
    [SerializeField] private float speed;
    [SerializeField] private float rotationSpeed;
    [SerializeField] private Transform[]movePoint;
    private int i;

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, movePoint[i].position, speed*Time.deltaTime);  

        if(Vector2.Distance(transform.position, movePoint[i].position) < .25f)
        {
            i++;
            if (i >= movePoint.Length)
                i = 0;
        }
    }
    protected override void OnTriggerEnter2D(Collider2D collision)
    {
        base.OnTriggerEnter2D(collision);
    }
}
