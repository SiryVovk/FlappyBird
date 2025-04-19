using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInput : MonoBehaviour
{
    private Player inputAction;

    private void Awake()
    {
        inputAction = new Player();
        inputAction.Enable();
    }
}
