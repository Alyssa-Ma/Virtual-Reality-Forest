using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropping : MonoBehaviour
{
    public Rigidbody holdable;
    //dropping position
    public GameObject dropPos;
    public GameObject pedestal;

    // Start is called before the first frame update
    void Start()
    {
        holdable.transform.parent = null;
        holdable.transform.localPosition = dropPos.transform.localPosition;
        holdable.transform.rotation = Quaternion.identity;
        holdable.transform.rotation = Quaternion.Euler(0, 0, 90);
        dropPos.SetActive(false);
        pedestal.layer = 0;
    }
}
