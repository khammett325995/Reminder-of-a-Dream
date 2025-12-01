using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DialogueManagement : MonoBehaviour
{
    //Fields

    //The Game's UI
    public GameObject myDialogueBox;
    public TextMeshProUGUI myText;

    //How to Advance the Dialogue
    private string[] myCurrentLine;
    private int myLineNum = 0;
    private bool myFirstLine = false;
    public static DialogueManagement myManager;

    private void Awake()
    {
        if (myManager == null)
        {
            myManager = this; 
            if(myDialogueBox != null) {
                myDialogueBox.SetActive(false);
            }
        } else if (myManager != this)
        {
            Debug.LogWarning("Duplicate DialogueManager");
            Destroy(gameObject);
        }
    }

    public void StartDialogue(string[] theLines)
    {
        myDialogueBox.SetActive(true);
        myCurrentLine = theLines;
        myLineNum = 0;
        myFirstLine = true;
        if (myCurrentLine.Length > 0)
        {
            myText.text = myCurrentLine[myLineNum];
        }
    }

    public void goToNextLine()
    {
        if (myCurrentLine == null)
        {
            return;
        }
        myLineNum++;
        if (myLineNum < myCurrentLine.Length)
        {
            if (myText != null) {
                myText.text = myCurrentLine[myLineNum];
            }
        } else
        {
            endText();
        }
    }

    public void endText()
    {
        myDialogueBox.SetActive(false);
        myText.text = "";
        myCurrentLine = null;
        myLineNum = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (myDialogueBox != null)
        {
            if (myFirstLine)
            {
                if (Input.anyKeyDown)
                {
                    myFirstLine = false;
                }
                //The return allows for the first line to show 
                return;
            }
            if (Input.anyKeyDown)
            {
                goToNextLine();
            }
        }
    }
}
