using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public abstract class AbstractButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IPointerEnterHandler, IPointerExitHandler
{
    private Vector2 _startingScale;
    protected Action onClick;
    public Image targetGraphic;
    private float animationScale = 1.2f;

    private void OnEnable()
    {
        targetGraphic = GetComponent<Image>();
        _startingScale = transform.localScale;
    }

    public void AddListener(Action onClick)
    {
        //this.onClick += onClick;
        this.onClick = onClick;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        transform.localScale *= animationScale;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        transform.localScale *= animationScale;
        onClick?.Invoke();
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        transform.localScale = _startingScale;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        transform.localScale = _startingScale;
    }
}
