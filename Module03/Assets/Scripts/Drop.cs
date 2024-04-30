using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Drop : MonoBehaviour, IDropHandler
{
    public string slotName;
    public GameObject[] turrent;
    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log(slotName + " " + eventData.pointerDrag.transform.name);
        if (eventData.pointerDrag.transform.name == "Turrent00")
        {
            DragNDrop drop = eventData.pointerDrag.GetComponent<DragNDrop>();
            if (drop != null)
            {
                Instantiate(turrent[0], transform.position,Quaternion.identity);
            }
        }
        if (eventData.pointerDrag.transform.name == "Turrent01")
        {
            DragNDrop drop = eventData.pointerDrag.GetComponent<DragNDrop>();
            if (drop != null)
            {
                Instantiate(turrent[1], transform.position, Quaternion.identity);
            }
        }
        if (eventData.pointerDrag.transform.name == "Turrent02")
        {
            DragNDrop drop = eventData.pointerDrag.GetComponent<DragNDrop>();
            if (drop != null)
            {
                Instantiate(turrent[2], transform.position, Quaternion.identity);
            }
        }
    }
}
