using UnityEngine;

public abstract class MovableObject : MonoBehaviour
{
    public float speed = 3f;
    public abstract void Move();
}
