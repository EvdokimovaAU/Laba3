using UnityEngine;

public class CameraControll : MonoBehaviour
{
    public Transform target;  // Цель (игрок)
    public float smoothSpeed = 0.125f; // Плавность движения (0.1 - медленно, 1 - мгновенно)
    public Vector3 offset;    // Смещение камеры относительно игрока

    void LateUpdate()
    {
        if (target == null)
            return;

        // Желаемая позиция камеры
        Vector3 desiredPosition = target.position + offset;

        // Плавное перемещение
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;
    }

}
