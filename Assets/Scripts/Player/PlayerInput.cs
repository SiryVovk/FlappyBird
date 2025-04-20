using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInput : MonoBehaviour
{
    [SerializeField] private float upForce = 5f;

    private Player inputAction;
    private Rigidbody2D rb;

    private void Awake()
    {
        inputAction = new Player();
        inputAction.Enable();
        inputAction.BirdInput.Jump.performed += ctx => Jump();
        rb = GetComponent<Rigidbody2D>();
    }

    private void Jump()
    {
        rb.AddForce(Vector2.up * upForce, ForceMode2D.Impulse);
    }
}
