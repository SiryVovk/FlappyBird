using UnityEngine;

public class BackGroundPosition : MonoBehaviour
{
    [SerializeField] private float positionXMoveTo = 40f;
    [SerializeField] private float positionXMoveFrom = -20f;

    void Update()
    {
        if (transform.position.x <= positionXMoveFrom)
        {
            transform.position = new Vector3(positionXMoveTo, 0);
        }
    }
}
