using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
    public TriggerTest resetColor;
    public bool ColorReset = false;

    // Start is called before the first frame update
    void Start()
    {
        
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
        print("Starting the game now");
        
        SubMenu.SetActive(true);
        MainMenuScreen.SetActive(false);
        unlockedColors.elements.Clear();// Clears the list when the player hits the start button. 

    }

    public void GameReturnButton()//Returns the player to the main game screen. 
    {
        print("Going back to menu screen");
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

    public void PageForward()
    {
        if (logbookScript.pageNumber <= 4)
        {
            logbookScript.pageNumber++;
            logbookScript.ClearLogbookPage();
            logbookScript.FillLogbookPageBasedOnPageNumber();
        }
    }
    public void PageBackward()
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
       
    }
}
