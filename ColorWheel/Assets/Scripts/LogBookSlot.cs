using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LogBookSlot : MonoBehaviour
{
    public Colors colorTemplate; 
    public Image sprite;
    public TMP_Text colorName; 
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        sprite.sprite = colorTemplate.sprite;//the sprite image is set to the image sprite in the referenced scriptable object.

        colorName.text = colorTemplate.color;

        
    }

    public void ShowDescription()
    {
        
        LogBook.logBook.DisplayDescrption(colorTemplate.unlockText);
    }
}
