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

    void Start()
    {
        unlockedColors.elements.Clear();//Everytime the game starts the list clears.
        SetColor(currentColor);//automatically adds whatever is the initial current color (blue) into the unlocked colors scriptable object.
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SetColor(Colors newColor)// function to create new colors in the game.
    {
        gameObject.GetComponent<Image>().sprite = newColor.sprite;//Setting the current sprite to be the current sprite. 
        print(" You unlocked a new color." + newColor.color);// lets me know what color I currenlty added to the unlocked scriptable item list.
        unlockedColors.elements.Add(newColor);//Adds the new color to the unlocked colors scriptable object. (to do: Do not allow duplicates.)
        currentColor = newColor;// Sets the new current color.

    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        print("You activated me");
       if(collision.gameObject.tag == "YellowNeedle")//if the object interacting with blue creature is a yellow needle.
        {


            SetColor(currentColor.yellowNeedleUnlock);//Retrives the info in yellowNeedleunlock in X color and sets it as the new color in the game.

        }

        if (collision.gameObject.tag == "RedNeedle")//Retrives the info in yellowNeedleunlock in X color and sets it as the new color in the game.
        {

            SetColor(currentColor.redNeedleUnlock);
           
        }
    }

}
