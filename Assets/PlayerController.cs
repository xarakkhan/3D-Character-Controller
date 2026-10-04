using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float walkSpeed = 3f;
    public float runSpeed = 6f;
    public float rotationSpeed = 10f;

    private Animator animator;
    private Rigidbody rb;

    void Start()
    {
        // Using explicit type-casting to completely bypass the Unity 6 generic inference error
        animator = GetComponent(typeof(Animator)) as Animator;
        rb = GetComponent(typeof(Rigidbody)) as Rigidbody;

        if (rb != null)
        {
            rb.freezeRotation = true;
        }
    }

    void FixedUpdate()
    {
        if (rb == null) return;

        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        Vector3 camForward = Camera.main != null ? Camera.main.transform.forward : Vector3.forward;
        Vector3 camRight = Camera.main != null ? Camera.main.transform.right : Vector3.right;

        camForward.y = 0f;
        camRight.y = 0f;

        camForward.Normalize();
        camRight.Normalize();

        Vector3 movement = (camForward * vertical + camRight * horizontal).normalized;

        bool isRunning = Input.GetKey(KeyCode.LeftShift);
        float currentSpeed = isRunning ? runSpeed : walkSpeed;

        Vector3 moveVelocity = movement * currentSpeed;
        moveVelocity.y = rb.linearVelocity.y;
        rb.linearVelocity = moveVelocity;

        if (movement.sqrMagnitude > 0.01f)
        {
            Quaternion targetRotation = Quaternion.LookRotation(movement);

            transform.rotation = Quaternion.Slerp(
                transform.rotation,
                targetRotation,
                rotationSpeed * Time.fixedDeltaTime
            );
        }
        else
        {
            rb.angularVelocity = Vector3.zero;
        }

        if (animator != null)
        {
            float animSpeed = 0f;

            if (movement.magnitude > 0.01f)
            {
                animSpeed = isRunning ? 1.0f : 0.5f;
            }

            animator.SetFloat("Speed", animSpeed);

            if (Input.GetKeyDown(KeyCode.Space))
            {
                animator.SetTrigger("Jump");
            }
        }
    }
}