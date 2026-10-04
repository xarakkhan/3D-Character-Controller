
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;

    public float distance = 7f;
    public float height = 4f;
    public float mouseSensitivity = 3f;

    private float rotationX = 20f;
    private float rotationY = 0f;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void LateUpdate()
    {
        if (player == null)
            return;

        // Mouse movement
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity;

        rotationY += mouseX;
        rotationX -= mouseY;

        // Limit up/down camera movement
        rotationX = Mathf.Clamp(rotationX, -20f, 60f);

        // Camera rotation
        Quaternion rotation =
            Quaternion.Euler(rotationX, rotationY, 0f);

        // Camera position around player
        Vector3 offset =
            rotation * new Vector3(0f, 0f, -distance);

        transform.position =
            player.position + Vector3.up * height + offset;

        // Look at player
        transform.LookAt(
            player.position + Vector3.up * 1.5f
        );

        // Press Escape to unlock mouse
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }
}

