using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger7 : MonoBehaviour
{
    public Dialogue7 dialogue;

    public void TriggerDialogue ()
    {
        FindObjectOfType<DialogueManager7>().StartDialogue(dialogue);
    }
}
