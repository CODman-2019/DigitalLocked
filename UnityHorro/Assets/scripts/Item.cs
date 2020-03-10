using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Item : MonoBehaviour
{
    public Text Prompt;

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(name);
            Prompt.text = "PICKUP " + name;
    }

    private void OnCollisionExit(Collision collision)
    {
        Prompt.text = null;
    }


}
