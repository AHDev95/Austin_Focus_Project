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
    private TextMeshProUGUI FuseCountText;
    [SerializeField]
    private UnityEvent Fabricate;
    [SerializeField]
    private UnityEvent FixFuse;
    [SerializeField]
    private UnityEvent tabletnote1;
    [SerializeField]
    private UnityEvent tabletnote2;
    private void OnTriggerEnter(Collider other) //add to the part count
    {
        if (other.gameObject.CompareTag("Parts"))
        {
            partCount++;
            FabCountText.text = partCount.ToString();
       
        if (partCount == 3)
        {
            tabletnote1.Invoke();

           
         }
        
        }

     


 if (other.gameObject.CompareTag("brokenFuse"))
        {
            partCount++;
            FuseCountText.text = partCount.ToString();
        
        
         if (partCount == 1)
        {
                tabletnote2.Invoke();
              
         }
        
         }

    }


    public void Fab1()
    {
        Fabricate.Invoke();
        partCount = 0;
        FuseCountText.text = partCount.ToString();
    }

    public void Fab2()
    {
        FixFuse.Invoke();
        partCount = 0;
        FuseCountText.text = partCount.ToString();
    }

    private void OnTriggerExit(Collider other) //reduce the part count
    {
        if (other.gameObject.CompareTag("Parts"))
        {
            partCount--;
            FabCountText.text = partCount.ToString();
        }

        if (other.gameObject.CompareTag("brokenFuse"))
        {
            partCount--;
            FabCountText.text = partCount.ToString();
        }
    }


}
