using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DebugMENU : MonoBehaviour
{
    bool textAccess;
    public GameObject ControlsLayout;
    public GameObject lights;
    public GameObject alterLights;

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            Debug.Log("Control text access");
            if (textAccess)
            {
                ControlsLayout.SetActive(true);
                textAccess = false;
            }
            else if (!textAccess)
            {
                ControlsLayout.SetActive(false);
                textAccess = true;
            }
        }
       

            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                lights.SetActive(false);
                alterLights.SetActive(true);

                GameObject temp = lights;
                lights = alterLights;
                alterLights = temp;

            }

    }

    //public void DebugOpen()
    //{
    //}

    //public void DebugClose()
    //{
    //    if ((Input.GetKeyUp(KeyCode.Alpha2)) && (debugAccess))
    //    {
    //        debugAccess = false;
    //    }
    //}

    //public void Reset()
    //{
    //    debugAccess = false;
    //    ControlsLayout.SetActive(false);
    //}
}
