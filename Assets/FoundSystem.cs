using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FoundSystem : MonoBehaviour
{
   public GameObject foundText;
   public static int theScore;

   void Update()
   {
       foundText.GetComponent<Text>().text = "Found: " + theScore;
   }
}
