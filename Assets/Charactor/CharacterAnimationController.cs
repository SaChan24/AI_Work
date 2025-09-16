// 13/9/2568 AI-Tag
// This was created with the help of Assistant, a Unity Artificial Intelligence product.

// 13/9/2568 AI-Tag
// This was created with the help of Assistant, a Unity Artificial Intelligence product.

using UnityEngine;

public class CharacterAnimationController : MonoBehaviour
{
    private Animator animator;

    void Start()
    {
        // Get the Animator component
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        // Check for R key press
        if (Input.GetKeyDown(KeyCode.R))
        {
            PlayAnimation("Agree_Gesture");
        }

        // Check for T key press
        if (Input.GetKeyDown(KeyCode.T))
        {
            PlayAnimation("Dead");
        }

        // Check for F key press
        if (Input.GetKeyDown(KeyCode.F))
        {
            PlayBlendTreeAnimation();
        }
        // Check if the "G" key is pressed
        if (Input.GetKeyDown(KeyCode.G))
        {
            // Trigger the "Fall Dead" animation
            animator.SetTrigger("FallDeadTrigger");
        }
    }

    private void PlayAnimation(string animationName)
    {
        // Reset all triggers and stop Blend Tree
        animator.ResetTrigger("Agree_Gesture");
        animator.ResetTrigger("Dead");
        animator.SetFloat("Speed", 0); // Reset Blend Tree parameter

        // Play the new animation
        animator.SetTrigger(animationName);
    }
   
private void PlayBlendTreeAnimation()
    {
        // Reset all triggers to stop other animations
        animator.ResetTrigger("Agree_Gesture");
        animator.ResetTrigger("Dead");

        // Trigger the Blend Tree animation
        animator.SetTrigger("PlayBlendTree");
    }
}