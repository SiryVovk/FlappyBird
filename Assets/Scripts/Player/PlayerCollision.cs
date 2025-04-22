using System;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public static event Action OnPlayerDeath;
    public static event Action OnPlayerPilarFlyThroough;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        OnPlayerDeath?.Invoke();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        OnPlayerPilarFlyThroough?.Invoke();
    }
}
