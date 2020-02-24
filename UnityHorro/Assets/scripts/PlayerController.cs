using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float walk;
    public float run;
    public float turn;

    float speed;

    public GameObject flashLight; private bool flashSwitch = false;



    // Update is called once per frame
    void Update()
    {
        speed = walk;

        if (Input.GetKey(KeyCode.W))
        {
            IsRunning();
            gameObject.transform.Translate(Vector3.forward * speed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            gameObject.transform.Translate(Vector3.back * speed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(new Vector3 (0.0f, -turn, 0.0f));
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(new Vector3(0.0f, turn, 0.0f));
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            if (flashSwitch == true)
            {
                flashLight.SetActive(false);
                flashSwitch = false;
            }
            else if(flashSwitch == false)
            {
                flashLight.SetActive(true);
                flashSwitch = true;
            }
        }

    }

    void IsRunning()
    {
        if (Input.GetKey(KeyCode.RightShift))
        {
            speed = run;
        }
    }
}

internal class gameObject
{
}