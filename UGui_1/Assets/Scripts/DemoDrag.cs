using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DemoDrag : MonoBehaviour, IDragHandler, IDropHandler {

    public RectTransform CanvasRect;
    private RectTransform rect;

    private bool is_First = true;
    private Vector2 offset;
    public void OnDrag(PointerEventData eventData)
    {
        Vector2 mousePos = eventData.position;
        Vector2 positon = new Vector2();
        bool isDrag = RectTransformUtility.ScreenPointToLocalPointInRectangle(CanvasRect, mousePos, eventData.enterEventCamera, out positon);

        if(is_First)
        {
            is_First = false;
            RectTransformUtility.ScreenPointToLocalPointInRectangle(rect, mousePos, eventData.enterEventCamera, out offset);
        }
        if(isDrag)
        {
            Debug.Log(positon);
            rect.anchoredPosition = positon - offset;
        }
    }

    public void OnDrop(PointerEventData eventData)
    {
        is_First = true;
    }

    // Use this for initialization
    void Start () {
        rect = transform as RectTransform;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
