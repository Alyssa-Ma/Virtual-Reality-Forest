using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
 
 
public class BridgeManager : MonoBehaviour
{
    public Text countText;
    public GameObject bridge;
 
    private Rigidbody rb;
    private int count;
    private const int totalWoodCount = 4;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
        SetCountText();
 
    }
 
    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("BridgePiece"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            SetCountText();
 
            if (count >= totalWoodCount) {
                makeBridge();
            }
        }
    }
 
    private void SetCountText()
    {
        int plankLeft = totalWoodCount - count;
        countText.text = plankLeft.ToString() + " Wood planks left";
        if (count >= totalWoodCount)
        {
            countText.text = "Go to cliff";
        }
    }
 
    private void makeBridge()
    {
        bridge.SetActive(true);
    }
 
}

