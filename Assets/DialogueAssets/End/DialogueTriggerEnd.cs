using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTriggerEnd : MonoBehaviour
{
    public DialogueEnd dialogue;

    public void TriggerDialogue ()
    {
        FindObjectOfType<DialogueManagerEnd>().StartDialogue(dialogue);
    }
}
