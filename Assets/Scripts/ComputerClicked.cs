using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComputerClicked : MonoBehaviour
{
    public DialogueManagement myDialogue;
    public string[] myLines = new string[]
    {
        "Staring at the screen with the blue light illuminating your room, you see the final essay’s title.",
        "You wrote the title earlier on this November 5th morning of “Reminder of a Dream: An Ode to the Future, Remembering the Past”.",
        "Excited with your recent recollections, you decide to write the essay filled with inspiration for the rest of the night."
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

