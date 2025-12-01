using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalendarClicked : MonoBehaviour
{
    public DialogueManagement myDialogue;
    public string[] myLines = new string[]
    {
        "Today, November 5th, marks the anniversary of when you found your passion and began the journey toward your future endeavors.",
        "It is also today that you were assigned the final assignment for your degree: to write a paper on “What career do you want to pursue?”",
        "Suddenly, you are filled with nostalgia, and you start to reflect on your journey so far by looking around your room to gain ideas for the paper."
    };
    
    private void OnMouseDown()
    {
        Debug.Log("Calendar was clicked! Attempting to start dialogue."); 
        myDialogue = DialogueManagement.myManager;
        if (myDialogue != null)
        {
            myDialogue.StartDialogue(myLines);
        }
                else
        {
            // Log a specific error if the manager instance is missing 
            Debug.LogError("FATAL ERROR: DialogueManagement.myManager is NULL. Dialogue system not initialized.");
        }
    }
}
