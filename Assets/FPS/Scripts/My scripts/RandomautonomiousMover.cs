using UnityEngine;

public class RandomMover2 : MovableObject, IAutonomous
{
    private Vector3 moveDirection;

    void Start()
    {
        PickRandomDirection();
        InvokeRepeating(nameof(PickRandomDirection), 2f, 2f); // Change direction every 2 seconds
    }

    void Update()
    {
        Move();
        Act(); // Perform an autonomous action
    }

    public override void Move()
    {
        transform.Translate(moveDirection * speed * Time.deltaTime);
    }

    public void Act()
    {
        // Example: Slightly rotate the object randomly as it moves
        transform.Rotate(0, Random.Range(-10f, 10f) * Time.deltaTime, 0);
    }

    void PickRandomDirection()
    {
        float randomX = Random.Range(-1f, 1f);
        float randomZ = Random.Range(-1f, 1f);
        moveDirection = new Vector3(randomX, 0, randomZ).normalized;
    }
}
