using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraChange : MonoBehaviour
{
    public GameObject Original;
    public GameObject Newcam;

    private void Update()
    {
     
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("CameraSwap complete");
            Original.SetActive(false);
            Newcam.SetActive(true);

            GameObject temp = Original;
            Original = Newcam;
            Newcam = temp;
        }
    }
}
