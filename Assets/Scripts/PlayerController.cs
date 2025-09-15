// 9/15/2025 AI-Tag
// This was created with the help of Assistant, a Unity Artificial Intelligence product.

// 9/15/2025 AI-Tag
// This was created with the help of Assistant, a Unity Artificial Intelligence product.

using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f; // Speed of the player
    public Animator animator;   // Reference to the Animator component

    private Vector3 movement;   // Stores movement input
    private Rigidbody rb;       // Reference to the Rigidbody component

    void Start()
    {
        // Get the Rigidbody component attached to the player
        rb = GetComponent<Rigidbody>();

        // Check if Rigidbody is missing
        if (rb == null)
        {
            Debug.LogError("Rigidbody component is missing on the Player GameObject. Please add a Rigidbody.");
        }

        // Ensure the Animator is assigned
        if (animator == null)
        {
            animator = GetComponent<Animator>();
            if (animator == null)
            {
                Debug.LogError("Animator component is missing on the Player GameObject. Please assign or add an Animator.");
            }
        }
    }

    void Update()
    {
        // Get input from the player
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        // Create a movement vector
        movement = new Vector3(horizontal, 0f, vertical);

        // Update the animator parameters
        if (animator != null)
        {
            animator.SetFloat("Speed", movement.magnitude);
        }
    }

    void FixedUpdate()
    {
        // Move the player using Rigidbody
        if (rb != null && movement != Vector3.zero)
        {
            rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
        }
    }
}
