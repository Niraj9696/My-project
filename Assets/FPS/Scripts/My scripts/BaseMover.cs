using UnityEngine;

public abstract class BaseMover : MonoBehaviour
{
    public float speed = 3f;

    public abstract void Move(); // Force subclasses to implement movement

    public void DisappearAndReappear()
    {
        gameObject.SetActive(false); // Hide the object
        Invoke(nameof(Reappear), 2f); // Wait 2 seconds, then reappear
    }

    private void Reappear()
    {
        gameObject.SetActive(true); // Show the object again
    }
}
