using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CellController : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
   [SerializeField] private float hoverScale = 1.2f;
   [SerializeField] private float scaleSpeed = 5f;

private RectTransform rectTransform;
private Vector2 originalScale;
private bool isHovering  = false;

private void Awake()
{
    rectTransform = GetComponent<RectTransform>();
    originalScale = rectTransform.localScale;
}

    private void Update()
    {
        Vector2 targetScale  = isHovering ? originalScale*hoverScale : originalScale;
        rectTransform.localScale = Vector2.Lerp(rectTransform.localScale, targetScale,scaleSpeed*Time.deltaTime);

    }



    public void OnPointerEnter(PointerEventData eventData)
    {
        isHovering = true;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        isHovering = false;
    }
}
