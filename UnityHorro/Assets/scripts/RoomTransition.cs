using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomTransition : MonoBehaviour
{
    public GameObject newLocation;
    public GameObject Original;
    public GameObject Newcam;

    GameObject current;

    private void Start()
    {
        current = newLocation;
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Body"))
        {
            other.transform.position = current.transform.position;
            Debug.Log("CameraSwap complete");
            Original.SetActive(false);
            Newcam.SetActive(true);
        }
    }
}
