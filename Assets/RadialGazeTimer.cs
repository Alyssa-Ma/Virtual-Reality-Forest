using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RadialGazeTimer : MonoBehaviour
{
    public float radialTimer = 0f;
    // public Transform radialProgress;
    public GameObject scriptButler;

    // Start is called before the first frame update
    // void Start()
    // {
    //     radialProgress.GetComponent<Image>().fillAmount = radialTimer;
        
    // }

    // Update is called once per frame
    void Update()
    {
        radialTimer += Time.deltaTime;

        // radialProgress.GetComponent<Image>().fillAmount = radialTimer / 2;

        if (radialTimer >= 2f)
        {
            ActivateButler();
        }

    }

    public void Reset()
    {
        radialTimer = 0f;
        // radialProgress.GetComponent<Image>().fillAmount = radialTimer;

    }

    public void ActivateButler()
    {
        scriptButler.SetActive(true);
    }
}