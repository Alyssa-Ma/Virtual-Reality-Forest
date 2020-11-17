using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Holding : MonoBehaviour
{
    public Transform holdPos;
    public GameObject holdable;
    public GameObject pedestal;

    // Start is called before the first frame update
    void Start()
    {
        holdable.transform.parent = holdPos.transform;
        holdable.transform.localPosition = holdPos.transform.localPosition;
        holdable.transform.rotation = holdPos.transform.rotation;
        holdable.layer = 0;
        pedestal.SetActive(true);
    }

}
