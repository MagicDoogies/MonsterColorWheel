using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

 public class DragAndDrop : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler, IDropHandler
{
    private RectTransform rectTransform;//containter to grab the image size of the affected object.

    [SerializeField] private Canvas canvas;//containter for UI canvas gameObject;

    public ResultsBox needleResult;
    public Vector2 originalPos;


    
    
    private void Start()
    {
        rectTransform = GetComponent<RectTransform>();//when the script is active take the dimensions of the image.

        originalPos = this.transform.position;//Takes the iniital position of the needle when the script is first activated.
    }

    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("OnDrag");
        rectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor;//First the script takes position of the cursor and ties the image position based on that. Next it divides the scale of the canvas so the image is correctly centered.
    }
    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("OnBeginDrag");
        
    }
    
    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("OnEndDrag");
     
    }
  public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("OnPointerDown");
        needleResult.NeedleClicked(this.gameObject);//Transfers information of the clicked needle to the NeedleClicked function inside 'ResultBox' script.
     
    }

    public void OnDrop(PointerEventData eventData)//When the needle is dropped it will go back to it's original position at the start of the game. 
    {
        this.transform.position = originalPos;
       

    }
}
