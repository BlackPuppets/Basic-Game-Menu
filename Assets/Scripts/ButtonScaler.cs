using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ButtonScaler : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    private Animator thisAnimator;
    private const string MOUSE_ENTER = "a_Enter";
    private const string MOUSE_EXIT = "a_Exit";

    private void Awake()
    {
        thisAnimator = GetComponent<Animator>();
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        thisAnimator.Play(MOUSE_ENTER);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        thisAnimator.Play(MOUSE_EXIT);
    }

}
