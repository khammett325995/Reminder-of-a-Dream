using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindowLedgeClicked : MonoBehaviour
{
    public DialogueManagement myDialogue;
    public string[] myLines = new string[]
    {
        "You stare at a splendid lake as you have for many years with its surrounding forest and ecosystems of trout, frogs, bass, and the lakeside flora.",
        "It reminds you of the many life adventures with your family throughout the years and how to find joy with those who care about you most."
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

