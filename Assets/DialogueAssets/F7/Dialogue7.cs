using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
//to pass into dialogue manager for new dialogue
public class Dialogue7
{
    public string name;

    [TextArea(3, 10)]
    //array of sentences we load into queue
    public string[] sentences;
}
