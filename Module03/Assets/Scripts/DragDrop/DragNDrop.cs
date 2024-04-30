using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public class DragNDrop : EventTrigger
{
    public Vector3 initialPos = Vector3.zero;
    public Image image;
    public GameObject turrentRef;
    private GameObject turrent;
    private float originalRadius;
    
    public override void OnBeginDrag(PointerEventData eventData)
    {
        turrent = Instantiate<GameObject>(turrentRef,transform.position,Quaternion.identity);
        turrent.GetComponent<Turrent>().enabled = false;
        image = GetComponent<Image>();
        initialPos = transform.position;
        image.raycastTarget = false;
        originalRadius = turrent.GetComponent<CircleCollider2D>().radius;
        turrent.GetComponent<CircleCollider2D>().radius = 0.2f;
    }

    public override void OnDrag(PointerEventData eventData)
    {
        Vector3 screenPos = Input.mousePosition;
        screenPos.z = -Camera.main.transform.position.z;
        turrent.transform.position = Camera.main.ScreenToWorldPoint(screenPos);
        
    }

    public override void OnEndDrag(PointerEventData eventData)
    {
        transform.position = initialPos;
        image.raycastTarget = true;
        // if (!turrent.GetComponent<Turrent>().instant)
        // {
        //     Destroy(turrent);
        // }
        // else{
            turrent.GetComponent<Turrent>().enabled = true;
            turrent.GetComponent<CircleCollider2D>().radius = originalRadius;
            turrent.transform.position = turrent.GetComponent<Turrent>().position;
        // }
    }
    
}
