using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger6 : MonoBehaviour
{
    public Dialogue6 dialogue;

    public void TriggerDialogue ()
    {
        FindObjectOfType<DialogueManager6>().StartDialogue(dialogue);
    }
}
