using UnityEngine;
using UnityEngine.Events;   // 引用 Unity 事件 API

/// <summary>
/// VR 互動物件
/// </summary>
public class VRInteractableObject : MonoBehaviour
{
    [Header("注視點滑入此物件的事件")]
    public UnityEvent onEnter;
    [Header("注視點滑出此物件的事件")]
    public UnityEvent onExit;
    [Header("注視點看到並點擊按鈕")]
    public UnityEvent onClick;

    public void OnPointerEnter()
    {
        onEnter.Invoke();
    }

    public void OnPointerExit()
    {
        onExit.Invoke();
    }

    public void OnPointerClick()
    {
        onClick.Invoke();
    }
}
