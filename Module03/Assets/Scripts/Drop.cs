using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Drop : MonoBehaviour, IDropHandler
{
    public string slotName;
    public GameObject turrent;
    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log(slotName + " " + eventData.pointerDrag.transform.name);
        if (eventData.pointerDrag.transform.name == slotName)
        {
            DragNDrop drop = eventData.pointerDrag.GetComponent<DragNDrop>();
            if (drop != null)
            {
                Instantiate(turrent, eventData.pointerDrag.transform.position,Quaternion.identity);
            }
        }
    }
}
