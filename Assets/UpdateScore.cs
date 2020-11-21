using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateScore : MonoBehaviour
{
   void OnTriggerEnter(Collider other)
   {
       FoundSystem.theScore += 1;
       Destroy(gameObject);
   }
}
