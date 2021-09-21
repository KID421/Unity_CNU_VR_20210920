using UnityEngine;

/// <summary>
/// 傳送管理器
/// </summary>
public class TeleportManager : MonoBehaviour
{
    [Header("玩家攝影機物件")]
    public Transform playerCamera;

    public void Teleport(Transform target)
    {
        playerCamera.position = target.position;
    }
}
