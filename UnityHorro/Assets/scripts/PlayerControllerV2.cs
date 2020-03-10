using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerV2 : MonoBehaviour
{
    public float walk;
    public float run;
    public float turn;
    float speed;

    Rigidbody rb;

    public GameObject flashLight;
    private bool flashSwitch = true;



    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        if (Input.GetKey(KeyCode.H))
        {
            transform.Rotate(new Vector3(0.0f, 0.0f, 0.0f));
            Debug.Log("object recalibrated");
        }

        speed = walk;

        //NOTE - TO the dumbass that made the character tester the character is backswards


        if (Input.GetKey(KeyCode.W))
        {
            IsRunning();
            //gameObject.transform.Translate(Vector3.forward * speed);
            rb.MovePosition(transform.position + Vector3.back * speed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            //gameObject.transform.Translate(Vector3.back * speed);
            rb.MovePosition(transform.position + Vector3.forward * speed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(new Vector3(0.0f, -turn, 0.0f));
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
            else if (flashSwitch == false)
            {
                flashLight.SetActive(true);
                flashSwitch = true;
            }
        }

    }

    void IsRunning()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            speed = run;
        }
    }

}
