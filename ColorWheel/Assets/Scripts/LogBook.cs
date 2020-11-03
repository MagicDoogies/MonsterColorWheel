using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Linq;

public class LogBook : MonoBehaviour
{
    public LogBookSlot slotprefab;
    public ColorContainer displayColors;
    public static LogBook logBook;
    // Start is called before the first frame update
    public TMP_Text colorDescription;
    public TMP_Text nameText;
    public TMP_Text heightText;
    public TMP_Text weightText;
    public TMP_Text typeText;
    public TMP_Text hexCode;

    public Image colorImage;

    public GameObject descriptionPanel;

    [HideInInspector] public int maxSlots = 9;// Set the maximum number of slots that show up on a single page. Public to other scripts. Private on the inspector.  
    public int pageNumber = 0;

    public void Awake()
    {
        logBook = this;
    }
    void OnEnable()
    {
        ClearLogbookPage();
        FillLogbookPageBasedOnPageNumber();
    }

    public void ClearLogbookPage()
    {
        foreach (Transform child in transform)//if any slots already exist in the logbook, delete it.
        {
            Debug.Log("I'm going away now" + child.name);
            
            Destroy(child.gameObject);
        }
    }

    public void FillLogbookPageBasedOnPageNumber()
    {
        for (int i = 0; i < maxSlots; i++)// This loops runs from zero to the number of max slots. 
        {
            Debug.Log("The loop index is: " + i);
            int dexNumber = i + maxSlots * pageNumber; // Checks to see it's position in the current pages 1-9

            if (dexNumber > displayColors.elements.Count - 1) break; //If the last entry of the logbook is reached, stop counting. 

            Debug.Log("The dex number is: " + dexNumber);
            if (displayColors.elements[dexNumber] != null)// 
            {
                var slot = Instantiate(slotprefab, transform);//creates a new instance of a logbook slot as a reference in the variable.
                slot.colorTemplate = displayColors.elements[dexNumber];//getting the slot just creating and setting it to the current color on the list.
                
            }
        }
    }


    public void DisplayDescrption(string description)//displays 'unlock text' text in the description box.
    {
        descriptionPanel.SetActive(true);
        colorDescription.text = description;

    }

    public void DisplayColorName(string name)//Displays the colors name in the description box. 
    {
        nameText.text = name;
    }
    public void DisplayColorWeight(string weight)//Displays the colors' weight in the description box. 
    {
        weightText.text = weight; 
    }
    public void DisplayColorHeight(string height)//Displays the colors' height in the description box. 
    {
        heightText.text = height;
    }
    public void DisplayColorHex(string hexnumber)//Displays the colors' hex code in the description box. 
    {
        hexCode.text = hexnumber;
    }
    public void DisplayColorType(string type)//Displays the color type in the description box. 
    {
        typeText.text = type;
    }
    public void DisplayColorImage(Sprite sprite)//Displays the color type in the description box. 
    {
        colorImage.sprite = sprite;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
