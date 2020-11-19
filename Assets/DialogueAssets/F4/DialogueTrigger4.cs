using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger4 : MonoBehaviour
{
    public Dialogue4 dialogue;

    public void TriggerDialogue ()
    {
        FindObjectOfType<DialogueManager4>().StartDialogue(dialogue);
    }
}
