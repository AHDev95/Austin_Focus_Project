using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fabricatorScript : MonoBehaviour
{
    int partCount = 0;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Parts"))
        {
            partCount++;
        }


    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Parts"))
        {
            partCount--;
        }
    }








}
