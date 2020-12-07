using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class OnClickFunctions : MonoBehaviour
{
    //public input fields for different canvases to toggle on and off in the game.
    public GameObject CreditsScreen;
    public GameObject MainMenuScreen;
    public GameObject GameScreen;
    public GameObject Logbook;
    public GameObject SubMenu;
    public LogBook logbookScript;
    public GameObject inputText;

    public GameObject audio;

    public GameObject menuTheme;
    public GameObject labTheme;
    public GameObject dexTheme;

    public ColorContainer unlockedColors;//refrence to the Unlocked colors list.
    public ColorContainer allColors;//reference to all possible colors in the game.


    //These declarations are for resetting the logbook info back to null when the player hits the start button.
    public GameObject defaultHexText;
    public GameObject defaultWeightText;
    public GameObject defaulttHeightText;
    public GameObject defaultDescriptionText;
    public GameObject defaultTypeText;
    public GameObject defaultColorNameText;
    

    public GameObject dexImage;
    public Image currentDexImage;
    public Image defaultDexImage;
    //End of logbook description gameobject references.


    public TriggerTest resetColor;
    public bool ColorReset = false;

    // Start is called before the first frame update
    void Start()
    {
        currentDexImage = dexImage.GetComponent<Image>();

        

    }

    // Update is called once per frame
    void Update()
    {
        if (Logbook.activeSelf == true)
        {
            menuTheme.SetActive(false);
            labTheme.SetActive(false);
            dexTheme.SetActive(true);
        }
       
        if (MainMenuScreen.activeSelf == true)
        {
            labTheme.SetActive(false);
            dexTheme.SetActive(false);
        }

        if (CreditsScreen.activeSelf == true)
        {
            labTheme.SetActive(false);
            dexTheme.SetActive(false);
        }

        if (GameScreen.activeSelf == true)
        {
            menuTheme.SetActive(false);
            labTheme.SetActive(true);
        }
        if (SubMenu.activeSelf == true)
        {
            labTheme.SetActive(false);
            dexTheme.SetActive(false);
            menuTheme.SetActive(true);
        }
    }

    public void CreditsButton()//if the credits button on the Home menus is selected, activate the Credits canvas and deactivate the Main menu screen.
    {
        FindObjectOfType<AudioManager>().Play("Clicked");

        CreditsScreen.SetActive(true);//turn on the credits screen.
        MainMenuScreen.SetActive(false);//turn off main menu screen.
    }

    public void CreditsReturn()//If players hit the Back button on the credits screen it activates the Main Menu canvas and deactivates the credits screen.
    {
        FindObjectOfType<AudioManager>().Play("Clicked");
        MainMenuScreen.SetActive(true);//turn on main menu screen
        CreditsScreen.SetActive(false);//turn off credits screen.
    }

    public void StartButton()
    {
        //this space will activate the main game UI and deactivate all the others.



        FindObjectOfType<AudioManager>().Play("Clicked");

        SubMenu.SetActive(true);
        MainMenuScreen.SetActive(false);
        unlockedColors.elements.Clear();// Clears the list when the player hits the start button. 
        currentDexImage.sprite = defaultDexImage.sprite;
        Debug.Log(currentDexImage.sprite);//The line and the entire section below establishes a default state for the description box when nothing has been selected or when the player restarts the game.
        defaultHexText.GetComponent<TMP_Text>().text = "---";
        defaulttHeightText.GetComponent<TMP_Text>().text = "---";
        defaultWeightText.GetComponent<TMP_Text>().text = "---";
        defaultTypeText.GetComponent<TMP_Text>().text = "---";
        defaultDescriptionText.GetComponent<TMP_Text>().text = "---";
        defaultColorNameText.GetComponent<TMP_Text>().text = "---";


        
        ResetColorNickname();//When the start button is clicked it activates this function.

    }

    public void GameReturnButton()//Returns the player to the main game screen. 
    {
        FindObjectOfType<AudioManager>().Play("Clicked");
        SubMenu.SetActive(false);
        MainMenuScreen.SetActive(true);


    }

    public void LogBookToSubmenu()//
    {
        FindObjectOfType<AudioManager>().Play("Clicked");
        Logbook.SetActive(false);
        SubMenu.SetActive(true);
    }

    public void SubMenuReturn()//If you are in the labratory scene, you get sent back to the submenu screen. 
    {
        FindObjectOfType<AudioManager>().Play("Clicked");
        GameScreen.SetActive(false);
        SubMenu.SetActive(true);
    }

    public void GoToLogBook()//Sends you to the logbook screen.
    {
        FindObjectOfType<AudioManager>().Play("Clicked");

        SubMenu.SetActive(false);
        Logbook.SetActive(true);
    }

    public void StartGameButton()//Takes you to the submenu when you hit the start button.
    {
        FindObjectOfType<AudioManager>().Play("Clicked"); //Play the button clicked audio from the AudioManager game object.

        GameScreen.SetActive(true);
        SubMenu.SetActive(false);
        
    }
    
    private void ResetColorNickname()//Clears the nicknames of all scriptable objects.
    {
        
        Colors[] colorArray = allColors.elements.ToArray();//Turning the All colors color container into an accessible array.
        foreach(Colors color in colorArray)
        {
            Debug.Log(color.name);
            color.hasNickname = false;
        }
    }

    public void ExitTheGame()//quits the game when pressed
    {
        Application.Quit();
    }

    public void PageForward()// Turns the next page.
    {
        if (logbookScript.pageNumber < (logbookScript.displayColors.elements.Count - 1)/9)
        {
            logbookScript.pageNumber++;
            Debug.Log("The page number is " + logbookScript.pageNumber);
            logbookScript.ClearLogbookPage();
            logbookScript.FillLogbookPageBasedOnPageNumber();
        }
    }
    public void PageBackward()//Go backward
    {
        //if pagenum is not zero
        //decrease pagenum by one
        if (logbookScript.pageNumber > 0)
        {
           
            logbookScript.pageNumber--;
            logbookScript.ClearLogbookPage();
            logbookScript.FillLogbookPageBasedOnPageNumber();
        }
    }

    public void ResetButton() //When this button is clicked it changes the sprite back to clear. This does NOT clear the elements list.
    {
        FindObjectOfType<AudioManager>().Play("Clicked");
        ColorReset = true;
        Debug.Log(ColorReset);
        resetColor.BackToClear();
    }

    public void SetNickname(string name)// function to allow players to change the nickname of the colors.
    {
        if (logbookScript.currentColor != null)// if there is a current color
        {
            print("I'm going to change the name of this monster.");
            logbookScript.currentColor.hasNickname = true;// Change the boolean that tracks whether or not a color has a nickname to true.
            logbookScript.currentColor.nickname = name;
            logbookScript.Refresh();
            inputText.SetActive(false);
        }
    }
}
