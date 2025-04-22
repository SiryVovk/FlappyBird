using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInput : MonoBehaviour
{
    [SerializeField] private float upForce = 5f;

    private Player inputAction;
    private Rigidbody2D rb;

    public static event Action JumpEvent;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnEnable()
    {
        inputAction = new Player();
        inputAction.Enable();
        inputAction.BirdInput.Jump.performed += OnJumpPerformed;
    }

    private void OnDisable()
    {
        inputAction.BirdInput.Jump.performed -= OnJumpPerformed;
        inputAction.Disable();
    }

    private void OnJumpPerformed(InputAction.CallbackContext ctx)
    {
        Jump();
    }

    private void Jump()
    {
        rb.AddForce(Vector2.up * upForce, ForceMode2D.Impulse);
        JumpEvent?.Invoke();
    }
}
