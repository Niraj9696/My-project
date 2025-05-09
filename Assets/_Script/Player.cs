using System.Runtime.CompilerServices;
using UnityEngine;

public class Player : MonoBehaviour
{
    //movement setting
    public bool startRun;
    public float moveSpeed;
    public float jumpForce;
    private bool canDoubleJump;

    // raycast
    [Header ("Speed info")]
    [SerializeField] private float maxSpeed;
    [SerializeField] private float speedMultiplier;
    [Space]
    [SerializeField] private float milestoneIncreaser;
    private float speedMilestone;
   
    //collision
    [Header("Collision info")]
    public float groundCheckDistance;
    public LayerMask Ground;
    private bool isGrounded;
    
    //components
    public Rigidbody2D rb;

    //Death variable
    private bool isAlive = true;

    public void Die()
    {
        if (!isAlive) return;
        isAlive = false;

        Debug.Log("Player died!");

        // Freeze the player movement
        rb.linearVelocity = Vector2.zero;
        rb.bodyType = RigidbodyType2D.Static; // Freeze completely

     
    }


    private void Start()
    {
        speedMilestone = milestoneIncreaser;
    }


    void Update()
    {
        HandleMovement();
        HandleJump();
        SpeedController();
    }
    void HandleMovement()
    {
        if (startRun)
        {
            rb.linearVelocity = new Vector2(moveSpeed, rb.linearVelocity.y); //apply horizontal movement while keeping vertical speed
        }
        if (Input.GetMouseButtonDown(0))
        {
            startRun = true;
        }
    }
    void HandleJump()
    {
        isGrounded = Physics2D.Raycast(transform.position, Vector2.down, groundCheckDistance, Ground);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            JumpButton();
        }

    }
    private void JumpButton()
    {
        if (isGrounded)
        {
            canDoubleJump = true;
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);//apply vertical movement while keeping verical speed
        }
        else if (canDoubleJump)
        {
            canDoubleJump = false;
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
        }
    }
    private void SpeedController()
    {
        if (moveSpeed == maxSpeed)
            return;
        if (transform.position.x > speedMilestone)
        {
            speedMilestone = speedMilestone + milestoneIncreaser;
            moveSpeed = moveSpeed * speedMultiplier;
            milestoneIncreaser = milestoneIncreaser * speedMultiplier;

            if(moveSpeed > maxSpeed)
            {
                moveSpeed = maxSpeed;
            }
        }
    }
}
