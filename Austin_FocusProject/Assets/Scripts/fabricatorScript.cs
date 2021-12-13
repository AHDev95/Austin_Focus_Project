using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Events;

public class fabricatorScript : MonoBehaviour
{
    [SerializeField]
    int partCount = 0;
    [SerializeField]
    private TextMeshProUGUI FabCountText;
    [SerializeField]
    private UnityEvent Fabricate;

    private void OnTriggerEnter(Collider other) //add to the part count
    {
        if (other.gameObject.CompareTag("Parts"))
        {
            partCount++;
            FabCountText.text = partCount.ToString();
        }

     if (partCount == 3)
        {
            Fabricate.Invoke();
        }
    }

    private void OnTriggerExit(Collider other) //reduce the part count
    {
        if (other.gameObject.CompareTag("Parts"))
        {
            partCount--;
            FabCountText.text = partCount.ToString();
        }
    }








}
