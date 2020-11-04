using System.Collections;
using System.Collections.Generic;
using UnityEngine;
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

    public ColorContainer unlockedColors;
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
        
    }

    public void CreditsButton()//if the credits button on the Home menus is selected, activate the Credits canvas and deactivate the Main menu screen.
    {
        CreditsScreen.SetActive(true);//turn on the credits screen.
        MainMenuScreen.SetActive(false);//turn off main menu screen.
    }

    public void CreditsReturn()//If players hit the Back button on the credits screen it activates the Main Menu canvas and deactivates the credits screen.
    {
        MainMenuScreen.SetActive(true);//turn on main menu screen
        CreditsScreen.SetActive(false);//turn off credits screen.
    }

    public void StartButton()
    {
        //this space will activate the main game UI and deactivate all the others.
        
        
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

    }

    public void GameReturnButton()//Returns the player to the main game screen. 
    {
      
        SubMenu.SetActive(false);
        MainMenuScreen.SetActive(true);


    }

    public void LogBookToSubmenu()//
    {
        Logbook.SetActive(false);
        SubMenu.SetActive(true);
    }

    public void SubMenuReturn()//If you are in the labratory scene, you get sent back to the submenu screen. 
    {
        GameScreen.SetActive(false);
        SubMenu.SetActive(true);
    }

    public void GoToLogBook()//Sends you to the logbook screen.
    {
        SubMenu.SetActive(false);
        Logbook.SetActive(true);
    }

    public void StartGameButton()//Takes you to the submenu when you hit the start button.
    {
        GameScreen.SetActive(true);
        SubMenu.SetActive(false);
    }

    public void ExitTheGame()//quits the game when pressed
    {
        Application.Quit();
    }

    public void PageForward()// Turns the next page.
    {
        if (logbookScript.pageNumber <= 2)
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
            logbookScript.pageForwardButton.interactable = true;
            logbookScript.pageNumber--;
            logbookScript.ClearLogbookPage();
            logbookScript.FillLogbookPageBasedOnPageNumber();
        }
    }

    public void ResetButton() //When this button is clicked it changes the sprite back to clear. This does NOT clear the elements list.
    {
        
        ColorReset = true;
        Debug.Log(ColorReset);
        resetColor.BackToClear();
    }
}
