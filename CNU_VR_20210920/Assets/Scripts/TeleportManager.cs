using UnityEngine;

/// <summary>
/// �ǰe�޲z��
/// </summary>
public class TeleportManager : MonoBehaviour
{
    [Header("���a��v������")]
    public Transform playerCamera;

    public void Teleport(Transform target)
    {
        playerCamera.position = target.position;
    }
}
