using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraChange : MonoBehaviour
{
    public GameObject Original;
    public GameObject Newcam;

    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GameObject temp = Original;

            Debug.Log("CameraSwap complete");
            Original.SetActive(false);
            Newcam.SetActive(true);

            Original = Newcam;
            Newcam = temp;
        }
    }
}
