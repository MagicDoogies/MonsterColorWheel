using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    public Dialogue dialogue;
    public Dialogue allPrimariesUnlocked;
    public Dialogue allColorsUnlocked;
    public Dialogue finalDialogue;
    public ColorContainer unlockedColors; //reference to the 'MonsterCounter' script.

   

    public GameObject logBook;
    public GameObject gameScreen;

    public int currentCount;
    private bool firstMilestone = true;
    private bool secondMilestone = false;
    private bool finalMilestone = false;


    //Since progress is directly tied to how many colors you unlock, this script reads how many monsters are currently unlocked and activates the function when players hit a certain threshold.
    public void Start()
    {
        
    }
    public void Update()
    {

        currentCount = unlockedColors.elements.Count;//Keeps constant track of how many elements are currently unlocked.
        

        if (currentCount == 1 && firstMilestone == true)
        {
         
           TriggerDialogue();
        }

        if (currentCount == 17 && secondMilestone == false)
        {
            dialogue = allPrimariesUnlocked;
            TriggerDialogue();
        }

        if (currentCount == 33 && finalMilestone == false)
        {
            dialogue = allColorsUnlocked;
            TriggerDialogue();
        }

    }

    public void TriggerDialogue()
    {
          
        if(firstMilestone == true)
        {
            FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
            firstMilestone = false;
        }
        else
        if(secondMilestone == false)
        {
            FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
            secondMilestone = true;
        }
        else
        if (finalMilestone == false)
        {
              FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
            finalMilestone = true;
        }
        else
        {
            FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
        }
       
    }
}
