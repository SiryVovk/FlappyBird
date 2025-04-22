using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    private Animator animator;

    private void OnEnable()
    {
        PlayerInput.JumpEvent += OnJump;
    }

    private void OnDisable()
    {
        PlayerInput.JumpEvent -= OnJump;
    }

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void OnJump()
    {
        animator.SetTrigger("Jump");
    }
}
