using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnClickFunctions : MonoBehaviour
{
    //public input fields for different canvases to toggle on and off in the game.
    public GameObject CreditsScreen;
    public GameObject MainMenuScreen;
    public GameObject GameScreen;
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
        GameScreen.SetActive(true);
        MainMenuScreen.SetActive(false);
    }

    public void GameReturnButton()//if clicked, returns player to the Main menu screen.
    {
        print("Going back to menu screen");
        MainMenuScreen.SetActive(true);
        GameScreen.SetActive(false);

    }
}
