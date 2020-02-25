using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float walk;
    public float run;
    public float turn;
    float speed;

    public GameObject flashLight;
    private bool flashSwitch = true;

    GameObject[] inventory = new GameObject[6];
    private GameObject item;

    public Text pickUpPrompt;

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.H))
        {
        //    transform.Rotate.x = 0.0f;
            transform.Rotate(new Vector3 (0.0f, 0.0f, 0.0f));
            Debug.Log("object recalibrated");
        }

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


    private void OnTriggerEnter(Collider other)
    {
            item = other.gameObject;

        if (other.CompareTag("Escape1 key"))
        {
            if (Input.GetKeyDown(KeyCode.P))
            {
                for(int i = 0; i< inventory.Length;i++)
                {
                    if(inventory[i] != null)
                    {
                        inventory[i] = item;
                        item.SetActive(false);
                        pickUpPrompt.text = "you picked up " + item; 
                    }
                }
            }
        }
    }
}
