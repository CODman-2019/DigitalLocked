using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraChangeroom : MonoBehaviour
{
    public GameObject Original;
    public GameObject Newcam;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("CameraSwap complete");
            Original.SetActive(false);
            Newcam.SetActive(true);
        }

    }
}
