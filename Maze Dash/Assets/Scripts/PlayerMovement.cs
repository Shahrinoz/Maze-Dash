using UnityEngine;

public class DebugInput : MonoBehaviour
{
    void Update()
    {
        Debug.Log("Update is running!"); // This should appear in the Console every frame

    }
}

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    private Animator animator;
    private Rigidbody2D rb;

    private Vector2 moveInput; // Store input
    private bool isNormalMode = false;

    void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.N))
        {
            isNormalMode = !isNormalMode;
        }

        if (isNormalMode)
        {
            rb.velocity = Vector2.zero;
            return;
        }

        // Keyboard input
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        // Combine both sources (keyboard or touch)
        Vector2 input = new Vector2(moveX, moveY);
        if (input != Vector2.zero)
            moveInput = input;

        // Move the player
        rb.velocity = moveInput * speed;

        // Trigger animations
        if (moveInput.x > 0) animator.SetTrigger("MoveRight");
        else if (moveInput.x < 0) animator.SetTrigger("MoveLeft");
        else if (moveInput.y > 0) animator.SetTrigger("MoveUp");
        else if (moveInput.y < 0) animator.SetTrigger("MoveDown");
    }

    // Called by UI buttons
    public void SetMoveDirection(string direction)
    {
        switch (direction)
        {
            case "Up": moveInput = Vector2.up; break;
            case "Down": moveInput = Vector2.down; break;
            case "Left": moveInput = Vector2.left; break;
            case "Right": moveInput = Vector2.right; break;
        }
    }

    public void StopMovement() => moveInput = Vector2.zero;
}
