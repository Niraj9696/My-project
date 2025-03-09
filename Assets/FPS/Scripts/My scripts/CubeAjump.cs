using UnityEngine;

public class CubeAjump : MonoBehaviour
{
    
    public float jumpForce = 5f; // Jump force
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        InvokeRepeating(nameof(Jump), 3f, 3f); // Jump every 3 seconds
    }

    void Jump()
    {
        rb.linearVelocity = new Vector3(rb.linearVelocity.x, 0, rb.linearVelocity.z); // Reset Y velocity
        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }

    // Public method to get the jump force
    public float GetJumpForce()
    {
        return jumpForce;
    }

}
