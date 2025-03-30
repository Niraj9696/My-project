using UnityEngine;

public class Autobot : BaseMover
{
    private Vector3 moveDirection;

    void Start()
    {
        PickRandomDirection();
        InvokeRepeating(nameof(PickRandomDirection), 2f, 2f);
        InvokeRepeating(nameof(DisappearAndReappear), 2f, 2f); // Disappear every 2 sec
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
        moveDirection = new Vector3(Random.Range(-1f, 1f), 0, Random.Range(-1f, 1f)).normalized;
    }
}
