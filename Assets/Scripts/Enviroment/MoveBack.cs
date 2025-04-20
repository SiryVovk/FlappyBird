using UnityEngine;

public class MoveBack : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private float positionXMoveTo = 40f;
    [SerializeField] private float positionXMoveFrom = -20f;

    private void Update()
    {
        transform.position += Vector3.left * moveSpeed * Time.deltaTime;

        if (transform.position.x <= positionXMoveFrom)
        {
            transform.position = new Vector3(positionXMoveTo, 0);
        }
    }
}
