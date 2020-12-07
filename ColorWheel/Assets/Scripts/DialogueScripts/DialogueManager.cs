using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogueManager : MonoBehaviour
{
    // Start is called before the first frame update

    private Queue<string> sentences;//this will contain any dialogue of text I have. 
  

    public TMP_Text nameText;
    public TMP_Text dialogueText;
    //These Text Mesh Pro dialogue boxes refer to the dialogue box components in the logbook scene. 
    public TMP_Text logbookNameText;
    public TMP_Text logbookDialogueText;

    public DialogueTrigger dialogueTrigger;
    public LogBookDialogueTrigger dialogueTrigger2;

    public GameObject bonusColorsUnlocked;
    //These game objects refer to the dialogue box in the logbook scene.
    public GameObject logbookDialogueBox;
    public GameObject gamelabDialogueBox;


    public bool gameFinished = false;

    public GameObject pastelNeedles;


    public Animator animator;//References the animtor component located on the textbox dialogue.
    public Animator animatorLogbook;
    public void Start()
    {
        sentences = new Queue<string>();//Initilializes the queue. 
        
    }
    // These functions are ONLY for handling the dialogue box in the LogBook Screen.
    public void StartDialogueInLogBook(Dialogue dialogue)
    {
       
        animatorLogbook.SetBool("LogIsOpen", true);//When the dialogue starts set the 'IsOpen' bool to true

        logbookNameText.text = dialogue.name;
        sentences.Clear(); //If any previous sentences exist, clear them out first.

        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }

       
        LogBookDisplayNextSentence();
    }
    public void LogBookDisplayNextSentence()
    {

        if (sentences.Count == 0)//If there are no more sentences to count-
        {
            LogBookEndDialogue();//Call the end dialogue function.
            return;
        }

        string sentence = sentences.Dequeue();// If there are more sentences to run (other element boxes) run those too. 
        
        StopAllCoroutines();
        StartCoroutine(LogBookTypeSentence(sentence));

    }
    IEnumerator LogBookTypeSentence(string sentence)
    {
        logbookDialogueText.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            FindObjectOfType<AudioManager>().Play("TextDisplay");
            logbookDialogueText.text += letter;
            yield return null;
        }
    }
    public void LogBookEndDialogue()
    {
        if (dialogueTrigger.currentCount == 36)
        {
            Debug.Log("End of conversation");
            animatorLogbook.SetBool("LogIsOpen", false);

        }
       
    }






    // The following functions is ONLY for the dialogue box in the Game Lab scene. 


    public void StartDialogue(Dialogue dialogue)
    {
       
            animator.SetBool("IsOpen", true);//When the dialogue starts set the 'IsOpen' bool to true

            nameText.text = dialogue.name;

            sentences.Clear(); //If any previous sentences exist, clear them out first.

            foreach (string sentence in dialogue.sentences)//for each sentence in the dialogue boxes
            {
                sentences.Enqueue(sentence);//Ready each sentence group in the dialogue boxes.
            }

            DisplayNextSentence();
        
    }

    public void DisplayNextSentence()
    {
        
        if (sentences.Count == 0)//If there are no more sentences to count-
        {
            EndDialogue();//Call the end dialogue function.
            return;
        }

        string sentence = sentences.Dequeue();// If there are more sentences to run (other element boxes) run those too. 
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));

    }
    IEnumerator TypeSentence (string sentence)
    {
        dialogueText.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            FindObjectOfType<AudioManager>().Play("TextDisplay");
            dialogueText.text += letter;
            yield return null;
        }
    }

    public void EndDialogue()
    {
        if (dialogueTrigger.currentCount == 36)
        {
            Debug.Log("End of conversation");
            animatorLogbook.SetBool("LogIsOpen", false);

                RestartBool();
        }
        else
        {
            Debug.Log("End of conversation");
            animator.SetBool("IsOpen", false);

            if (dialogueTrigger.currentCount == 17)//Displays the pastel needles after the conversation ends. 
            {
                pastelNeedles.SetActive(true);
            }

            if (dialogueTrigger.currentCount == 33 && gameFinished == false)
            {

                RestartBool();
            }
        }

    }

    public void RestartBool()
    {
        //IF the function detects that the player hit another current count milestone it will reset the animator bool to true.
        if (dialogueTrigger.currentCount == 36)
        {
            animatorLogbook.SetBool("LogIsOpen", false);
        }
        else
        {
            if (dialogueTrigger.currentCount == 17)
            {
                animator.SetBool("IsOpen", false);
            }

            if (dialogueTrigger.currentCount == 33)
            {
                animator.SetBool("IsOpen", false);
                bonusColorsUnlocked.SetActive(true);
                gameFinished = true;

            }
        }

    }
}
