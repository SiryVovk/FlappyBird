using UnityEngine;

public class PilarDisable : MonoBehaviour
{
    [SerializeField] private float disablePosition = -20f;

    private SpawnPilars spawnPilars;

    private void Awake()
    {
        spawnPilars = GameObject.FindFirstObjectByType<SpawnPilars>();
    }

    private void Update()
    {
        if (transform.position.x <= disablePosition)
        {
            spawnPilars.AddToDisabled(gameObject);
            gameObject.SetActive(false);
        }
    }
}
