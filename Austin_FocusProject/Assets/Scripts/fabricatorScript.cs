using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fabricatorScript : MonoBehaviour
{
   [SerializeField]
    int partCount = 0;
    private void OnTriggerEnter(Collider other) //add to the part count
    {
        if (other.gameObject.CompareTag("Parts"))
        {
            partCount++;
        }

     
    }

    private void OnTriggerExit(Collider other) //reduce the part count
    {
        if (other.gameObject.CompareTag("Parts"))
        {
            partCount--;
        }
    }








}
