using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class NeedleSlot : MonoBehaviour, IDropHandler
{
    // Start is called before the first frame update
    public Vector2 slot1;
    public Vector2 slot2;
    public Vector2 slot3;
    public Vector2 slot4;
    public Vector2 slot5;
    public Vector2 slot6;

    

   
    public void Start()
    {
       slot1 = gameObject.transform.position;
       slot2 = gameObject.transform.position;
       slot3 = gameObject.transform.position;
       slot4 = gameObject.transform.position;
       slot5 = gameObject.transform.position;
       slot6 = gameObject.transform.position;


    }
    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("On Drop");
        if (eventData.pointerDrag.tag == "Red")
        {
            Debug.Log("You dropped the needle color " + gameObject.tag);
            gameObject.transform.position = slot1;
            /*eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = slot1.transform.position; GetComponent<RectTransform>().anchoredPosition;*/
        }
        if (eventData.pointerDrag.tag == "Blue")
        {
            eventData.pointerDrag.transform.position = slot2;
            /*eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = slot2.transform.position; GetComponent<RectTransform>().anchoredPosition;*/
        }
        if (eventData.pointerDrag.tag == "Yellow")
        {
            eventData.pointerDrag.transform.position = slot3;
            /*eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = slot3.transform.position; GetComponent<RectTransform>().anchoredPosition;*/
        }
    }

}
