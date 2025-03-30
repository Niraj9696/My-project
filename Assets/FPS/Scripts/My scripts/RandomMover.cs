using UnityEngine;

public class RandomMover : MovableObject
{
    private Vector3 moveDirection;

    void Start()
    {
        PickRandomDirection();
        InvokeRepeating(nameof(PickRandomDirection), 2f, 2f);
    }

    void Update()
    {
        Move();
    }

    public override void Move()
    {
        transform.Translate(moveDirection * speed * Time.deltaTime);
    }

    void PickRandomDirection()
    {
        float randomX = Random.Range(-1f, 1f);
        float randomZ = Random.Range(-1f, 1f);
        moveDirection = new Vector3(randomX, 0, randomZ).normalized;
    }
}
