using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TpWallsDown : MonoBehaviour
{
    public GameObject obj;
    void Update()
    {
        if(FoundSystem.theScore == 5)
        {
            Destroy(gameObject);
        }
    }
}
