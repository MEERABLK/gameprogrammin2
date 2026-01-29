using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform ball;      // Drag your ball here in Inspector
    public Vector3 offset = new Vector3(0, 5, -10);
    public float smoothSpeed = 0.125f;

    void LateUpdate()
    {
        if (ball == null) return;

        Vector3 desiredPosition = ball.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;

        transform.LookAt(ball);
    }
}
