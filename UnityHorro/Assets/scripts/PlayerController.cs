using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float walk;
    public float run;
    public float turn;

    float speed;


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
    }

    void IsRunning()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            speed = run;
        }
    }
}
