// 9/15/2025 AI-Tag
// This was created with the help of Assistant, a Unity Artificial Intelligence product.

using System;
using UnityEditor;
using UnityEngine;
// 9/15/2025 AI-Tag
// This was created with the help of Assistant, a Unity Artificial Intelligence product.


public class CameraFollow : MonoBehaviour
{
    public Transform target; // The player or object the camera will follow
    public Vector3 offset = new Vector3(0f, 5f, -10f); // Offset position relative to the target
    public float smoothSpeed = 0.125f; // Smoothing speed for camera movement

    void LateUpdate()
    {
        if (target == null)
        {
            Debug.LogError("Target is not assigned to the CameraFollow script. Please assign a target.");
            return;
        }

        // Calculate the desired position
        Vector3 desiredPosition = target.position + offset;

        // Smoothly interpolate to the desired position
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);

        // Update the camera's position
        transform.position = smoothedPosition;

        // Optionally, make the camera look at the target
        transform.LookAt(target);
    }
}
