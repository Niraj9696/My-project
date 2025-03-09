using UnityEngine;

public class CubeBjump : MonoBehaviour
{
    public CubeAjump cubeAjump; // Reference to CubeAjump
    private Rigidbody rb;
    private float jumpForce;

    void Start()
    {
        rb = GetComponent<Rigidbody>();

        if (cubeAjump != null)
        {
            jumpForce = cubeAjump.GetJumpForce() / 2f; // Half of CubeAjump's jump force
            InvokeRepeating(nameof(Jump), 3f, 3f); // Sync jump timing with CubeAjump
            Debug.Log($"CubeBjump jump force set to: {jumpForce}");
        }
        else
        {
            Debug.LogError("CubeAjump reference not assigned in CubeBjump! Disabling script.");
            enabled = false;
        }
    }

    void Jump()
    {
        rb.linearVelocity = new Vector3(rb.linearVelocity.x, 0, rb.linearVelocity.z); // Reset Y velocity
        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }
}
