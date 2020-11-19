using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger3 : MonoBehaviour
{
    public Dialogue3 dialogue;

    public void TriggerDialogue ()
    {
        FindObjectOfType<DialogueManager3>().StartDialogue(dialogue);
    }
}
