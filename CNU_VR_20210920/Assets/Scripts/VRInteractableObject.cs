using UnityEngine;
using UnityEngine.Events;   // �ޥ� Unity �ƥ� API

/// <summary>
/// VR ���ʪ���
/// </summary>
public class VRInteractableObject : MonoBehaviour
{
    [Header("�`���I�ƤJ�����󪺨ƥ�")]
    public UnityEvent onEnter;
    [Header("�`���I�ƥX�����󪺨ƥ�")]
    public UnityEvent onExit;
    [Header("�`���I�ݨ���I�����s")]
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
