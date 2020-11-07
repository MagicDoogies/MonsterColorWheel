using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogBookDialogueTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    public Dialogue finalConversation;
    public ColorContainer unlockedColors; //reference to the 'MonsterCounter' script.

    public GameObject gameDialogueTrigger;

    public GameObject logBook;
    public GameObject gameScreen;

    public bool endConversation = false;

    public int currentCount;
   

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        currentCount = unlockedColors.elements.Count;//Keeps constant track of how many elements are currently unlocked.
       

        if (currentCount == 36 && endConversation == false)// If the counter unlocked counter is 36 AND the player is in the logbook screen, run this dialogue.
        {
            
            TriggerDialogue();
        }

    }

    public void TriggerDialogue()
    {
        if (currentCount == 36 && endConversation == false)
        {
           
            
            FindObjectOfType<DialogueManager>().StartDialogueInLogBook(finalConversation);

            endConversation = true;
        }
    }
}
