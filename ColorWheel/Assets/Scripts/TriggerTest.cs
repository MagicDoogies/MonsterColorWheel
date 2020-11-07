using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class TriggerTest : MonoBehaviour
{
    // Start is called before the first frame update

    

    public ColorContainer unlockedColors;
    public Colors currentColor;
    public Colors initialColor; // The first color that the player gets when they start the game. 
    public ResultsBox resultBox;
    public OnClickFunctions resetColors;

    public DialogueManager dialogueManager;
    void OnEnable()
    {
        
        SetColor(initialColor); //Upon the list being cleared, insures that the first unlocked color is 'clear' sprite.  
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void BackToClear()//When the reset button is clicked in the ButtonFunctions script, it sets the color back to clear WITHOUT clearing the elements list.
    {
        if (resetColors.ColorReset == true)
        {

            SetColor(initialColor);
            resetColors.ColorReset = false;
          
        }
    }

    public void SetColor(Colors newColor)// function to create new colors in the game.
    {
        gameObject.GetComponent<Image>().sprite = newColor.sprite;//Setting the current sprite to be the current sprite. 
       
        if (!unlockedColors.elements.Contains(newColor))//Checking if the color is already in the list
        {
            unlockedColors.elements.Add(newColor);//Adds the new color to the unlocked colors scriptable object. (to do: Do not allow duplicates.)
        }
        currentColor = newColor;// Sets the new current color.
        resultBox.MonsterChange(newColor);
        
        
    }

    public void OnTriggerEnter2D(Collider2D collision)// if player uses a needle with X tag on Y color it turns into Z. In other words, this controls the color mixing function. 
    {
       

       if(collision.gameObject.tag == "Yellow")//if the object interacting with blue creature is a yellow needle.
        {

            SetColor(currentColor.yellowNeedleUnlock);//Retrives the info in yellowNeedleunlock in X color and sets it as the new color in the game.
            
        }
   

        if (collision.gameObject.tag == "Red")//Retrives the info in yellowNeedleunlock in X color and sets it as the new color in the game.
        {

            SetColor(currentColor.redNeedleUnlock);
            
        }
  

        if (collision.gameObject.tag == "Blue")//Retrives the info in yellowNeedleunlock in X color and sets it as the new color in the game.
        {

            SetColor(currentColor.blueNeedleUnlocked);
           
        }


        if (collision.gameObject.tag == "PastelBlue")//Retrives the info in yellowNeedleunlock in X color and sets it as the new color in the game.
        {

            SetColor(currentColor.pastelBlueUnlocked);
           
        }
  

        if (collision.gameObject.tag == "PastelYellow")//Retrives the info in yellowNeedleunlock in X color and sets it as the new color in the game.
        {

            SetColor(currentColor.pastelYellowunlocked);
            
        }
    

        if (collision.gameObject.tag == "PastelRed")//Retrives the info in yellowNeedleunlock in X color and sets it as the new color in the game.
        {

            SetColor(currentColor.pastelRedUnlocked);

        }
    
        
    }

}
