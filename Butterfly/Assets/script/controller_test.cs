using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using OVRTouchSample;

public class controller_test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.Get(OVRInput.RawButton.RIndexTrigger))
        {
            Debug.Log("trigger");
        }
    }
}
