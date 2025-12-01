using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LetterClicked : MonoBehaviour
{
 
    public DialogueManagement myDialogue;
    public string[] myLines = new string[]
    {
        "You pick up the letter from the desk.",
        "The envelope and letter are from your grandfather and are dated three years ago from today, a previous November 5th.",
        "The letter reads: “…",
        "Remember…",
        "Remember!",
        "Remember to always continue to follow your dreams while living a life that makes you happy.”",
        "Reminiscing from your grandfather’s words, memories of the day warmly rush into your thoughts as it was the day you learned."
    };
    
    private void OnMouseDown()
    {
        myDialogue = DialogueManagement.myManager;
        if (myDialogue != null)
        {
            myDialogue.StartDialogue(myLines);
        }
    }
}