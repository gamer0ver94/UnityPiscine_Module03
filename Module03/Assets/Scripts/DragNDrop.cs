using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public class DragNDrop : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public Vector3 initialPos = Vector3.zero;
    public Image image;
    public void OnBeginDrag(PointerEventData eventData)
    {
        image = GetComponent<Image>();
        initialPos = transform.position;
        image.raycastTarget = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        Vector3 screenPos = Input.mousePosition;
        screenPos.z = -Camera.main.transform.position.z;
        transform.position = Camera.main.ScreenToWorldPoint(screenPos);

        
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        transform.position = initialPos;
        image.raycastTarget = true;
    }
    
}
