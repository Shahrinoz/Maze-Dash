using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // Player
    public float minX, maxX, minY, maxY; // Clamp boundaries

    void LateUpdate()
    {
        if (target == null) return;

        Vector3 newPos = new Vector3(
            Mathf.Clamp(target.position.x, minX, maxX),
            Mathf.Clamp(target.position.y, minY, maxY),
            -10f 
        );

        transform.position = newPos;
    }
}
