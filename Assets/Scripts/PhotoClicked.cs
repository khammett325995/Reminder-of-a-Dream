using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectInteraction : MonoBehaviour
{
    public DialogueManagement myDialogue;
    public string[] myLines = new string[]
    {
        "You look at a photo frame that holds two photos: a photo of family and friends and a photo of a bunny.",
        "This causes you to pause and think of the good memories that you have created so far.",
        "You are also reminded of the life lessons that you have carried throughout your ambitions so far."
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

