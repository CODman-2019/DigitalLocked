using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugMENU : MonoBehaviour
{
    private bool debugAccess;
    public GameObject lights;
    public GameObject alterLights;

    // Start is called before the first frame update
    void Start()
    {
        debugAccess = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tilde))
        {
            debugAccess = true;
        }

        if (debugAccess)
        {
            if (Input.GetKey(KeyCode.L))
            {
                lights.SetActive(false);
                alterLights.SetActive(true);

                GameObject temp = lights;
                lights = alterLights;
                alterLights = temp;

            }
        }
    }
}
