using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomTransition : MonoBehaviour
{
    public GameObject newLocation;

    GameObject current;

    private void Start()
    {
        current = newLocation;
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.transform.position = current.transform.position;
        }
    }
}
