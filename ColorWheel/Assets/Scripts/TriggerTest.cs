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

    public void OnTriggerEnter2D(Collider2D collision)// if player uses a needle with X tag on Y color it turns into Z. In other words, this controls the color mixing function. 
    {
        print("You activated me");

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
        if (collision.gameObject.tag == "Green")//Retrives the info in yellowNeedleunlock in X color and sets it as the new color in the game.
        {

            SetColor(currentColor.greenNeedleUnlock);

        }
        if (collision.gameObject.tag == "Orange")//Retrives the info in yellowNeedleunlock in X color and sets it as the new color in the game.
        {

            SetColor(currentColor.orangeNeedleUnlock);

        }
        if (collision.gameObject.tag == "Purple")//Retrives the info in yellowNeedleunlock in X color and sets it as the new color in the game.
        {

            SetColor(currentColor.purpleNeedleUnlocked);

        }
        if (collision.gameObject.tag == "Lime")//if the object interacting with blue creature is a yellow needle.
        {


            SetColor(currentColor.limeNeedleUnlock);//Retrives the info in yellowNeedleunlock in X color and sets it as the new color in the game.

        }

        if (collision.gameObject.tag == "Magenta")//Retrives the info in yellowNeedleunlock in X color and sets it as the new color in the game.
        {

            SetColor(currentColor.magentaNeedleUnlock);

        }
        if (collision.gameObject.tag == "Teal")//Retrives the info in yellowNeedleunlock in X color and sets it as the new color in the game.
        {

            SetColor(currentColor.tealNeedleUnlocked);

        }
        if (collision.gameObject.tag == "Vermillion")//Retrives the info in yellowNeedleunlock in X color and sets it as the new color in the game.
        {

            SetColor(currentColor.vermillionNeedleUnlock);

        }
        if (collision.gameObject.tag == "Violet")//Retrives the info in yellowNeedleunlock in X color and sets it as the new color in the game.
        {

            SetColor(currentColor.violetNeedleUnlock);

        }
        if (collision.gameObject.tag == "Amber")//Retrives the info in yellowNeedleunlock in X color and sets it as the new color in the game.
        {

            SetColor(currentColor.amberNeedleUnlocked);

        }
        if (collision.gameObject.tag == "Blush")//if the object interacting with blue creature is a yellow needle.
        {


            SetColor(currentColor.blushNeedleUnlock);//Retrives the info in yellowNeedleunlock in X color and sets it as the new color in the game.

        }

        if (collision.gameObject.tag == "Sky")//Retrives the info in yellowNeedleunlock in X color and sets it as the new color in the game.
        {

            SetColor(currentColor.skyNeedleUnlock);

        }
        if (collision.gameObject.tag == "Custard")//Retrives the info in yellowNeedleunlock in X color and sets it as the new color in the game.
        {

            SetColor(currentColor.custardNeedleUnlocked);

        }
        if (collision.gameObject.tag == "Orchid")//Retrives the info in yellowNeedleunlock in X color and sets it as the new color in the game.
        {

            SetColor(currentColor.orchidNeedleUnlock);

        }
        if (collision.gameObject.tag == "Seafoam")//Retrives the info in yellowNeedleunlock in X color and sets it as the new color in the game.
        {

            SetColor(currentColor.seafoamNeedleUnlock);

        }
        if (collision.gameObject.tag == "Peach")//Retrives the info in yellowNeedleunlock in X color and sets it as the new color in the game.
        {

            SetColor(currentColor.peachNeedleUnlocked);

        }
        if (collision.gameObject.tag == "Crystal")//if the object interacting with blue creature is a yellow needle.
        {


            SetColor(currentColor.crystalNeedleUnlock);//Retrives the info in yellowNeedleunlock in X color and sets it as the new color in the game.

        }

        if (collision.gameObject.tag == "Coral")//Retrives the info in yellowNeedleunlock in X color and sets it as the new color in the game.
        {

            SetColor(currentColor.coralNeedleUnlock);

        }
        if (collision.gameObject.tag == "Blueberry")//Retrives the info in yellowNeedleunlock in X color and sets it as the new color in the game.
        {

            SetColor(currentColor.blueberryNeedleUnlocked);

        }
        if (collision.gameObject.tag == "Bubblegum")//Retrives the info in yellowNeedleunlock in X color and sets it as the new color in the game.
        {

            SetColor(currentColor.bubblegumNeedleUnlock);

        }
        if (collision.gameObject.tag == "Chartreuse")//Retrives the info in yellowNeedleunlock in X color and sets it as the new color in the game.
        {

            SetColor(currentColor.chartreuseNeedleUnlock);

        }
        if (collision.gameObject.tag == "Brown")//Retrives the info in yellowNeedleunlock in X color and sets it as the new color in the game.
        {

            SetColor(currentColor.brownNeedleUnlocked);

        }
        if (collision.gameObject.tag == "Coffee")//Retrives the info in yellowNeedleunlock in X color and sets it as the new color in the game.
        {

            SetColor(currentColor.coffeeNeedleUnlocked);

        }
    }

}
