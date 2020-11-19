using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger5 : MonoBehaviour
{
    public Dialogue5 dialogue;

    public void TriggerDialogue ()
    {
        FindObjectOfType<DialogueManager5>().StartDialogue(dialogue);
    }
}
