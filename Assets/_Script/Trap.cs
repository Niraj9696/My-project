using UnityEngine;

public class Trap : MonoBehaviour
{
    protected virtual  void OnTriggerEnter2D(Collider2D collision)
    {
        Player player = collision.GetComponent<Player>();
        if (player != null)
        {
            player.Die();
        }
    }
}
