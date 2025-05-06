using UnityEngine;

public class CameraControll : MonoBehaviour
{
    public Transform target;  // ���� (�����)
    public float smoothSpeed = 0.125f; // ��������� �������� (0.1 - ��������, 1 - ���������)
    public Vector3 offset;    // �������� ������ ������������ ������

    void LateUpdate()
    {
        if (target == null)
            return;

        // �������� ������� ������
        Vector3 desiredPosition = target.position + offset;

        // ������� �����������
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;
    }

}
