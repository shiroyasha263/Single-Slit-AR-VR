using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class drag_handler : MonoBehaviour, IDragHandler, IPointerDownHandler
{
    public RectTransform Transform;
    public Canvas canvas;

    public void OnDrag(PointerEventData eventData)
    {
        Transform.anchoredPosition += eventData.delta / canvas.scaleFactor;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        Transform.SetAsLastSibling();
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

}
