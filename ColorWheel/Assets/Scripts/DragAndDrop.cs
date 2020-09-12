using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

 public class DragAndDrop : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    private RectTransform rectTransform;//containter to grab the image size of the affected object.

    [SerializeField] private Canvas canvas;//containter for UI canvas gameObject;
    
    
    
    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();//when the script is active take the dimensions of the image.
    }

    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("OnDrag");
        rectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor;//First the script takes position of the cursor and ties the image position based on that. Next it divides the scale of the canvas so the image is correctly centered.
    }
    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("OnBeginDrag");
        throw new System.NotImplementedException();
    }
    
    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("OnEndDrag");
        throw new System.NotImplementedException();
    }
  public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("OnPointerDown");
        throw new System.NotImplementedException();
    }


}
