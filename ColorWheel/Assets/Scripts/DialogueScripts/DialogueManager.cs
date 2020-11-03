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
    public DialogueTrigger dialogueTrigger;

    public bool gameFinished = false;

    public GameObject pastelNeedles;


    public Animator animator;//References the animtor component located on the textbox dialogue.

    public void Start()
    {
        sentences = new Queue<string>();//Initilializes the queue. 
    }

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

       /* dialogueText.text = sentence;*/
        
       
    }
    IEnumerator TypeSentence (string sentence)
    {
        dialogueText.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            dialogueText.text += letter;
            yield return null;
        }
    }

    public void EndDialogue()
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

    public void RestartBool()
    {
        //IF the function detects that the player hit another current count milestone it will reset the animator bool to true.
       if( dialogueTrigger.currentCount == 17)
        {
            animator.SetBool("IsOpen", false);
        }
      
       if(dialogueTrigger.currentCount == 33)
        {
            animator.SetBool("IsOpen", false);
            gameFinished = true;

        }
       /* else
        {
            animator.SetBool("IsOpen", false);
        }
      */
    }
}
