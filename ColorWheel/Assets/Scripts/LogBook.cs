using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LogBook : MonoBehaviour
{
    public LogBookSlot slotprefab;
    public ColorContainer displayColors;
    public static LogBook logBook;
    // Start is called before the first frame update
    public TMP_Text colorDescription;
    public GameObject descriptionPanel;
    public void Awake()
    {
        logBook = this;
    }
    void OnEnable()
    {
        foreach (Transform child in transform)//if any slots already exist in the logbook, delete it.
        {
            Destroy(child);
        }

        foreach (var color in displayColors.elements)
        {
           var slot =  Instantiate(slotprefab, transform);//creates a new instance of a logbook slot as a reference in the variable.
            slot.colorTemplate = color;//getting the slot just creating and setting it to the current color on the list.
            
        }


    }

    public void DisplayDescrption(string description)
    {
        descriptionPanel.SetActive(true);
        colorDescription.text = description;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
