using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger1 : MonoBehaviour
{
    public Dialogue1 dialogue;

    public void TriggerDialogue ()
    {
        FindObjectOfType<DialogueManager1>().StartDialogue(dialogue);
    }
}
