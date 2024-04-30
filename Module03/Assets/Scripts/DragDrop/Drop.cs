using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Drop : EventTrigger
{
    public string slotName;
    public override void OnDrop(PointerEventData eventData)
    {
        DragNDrop drop = eventData.pointerDrag.GetComponent<DragNDrop>();
        if (drop != null)
        {
           drop.GetComponent<TurrentSlot>().isAble = true;
        }
    }
}
