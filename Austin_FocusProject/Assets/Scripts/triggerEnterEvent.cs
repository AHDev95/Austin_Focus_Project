using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class triggerEnterEvent : MonoBehaviour
{
    [SerializeField]
    private UnityEvent onTriggerEnter;
    [SerializeField]
    GameObject keyitem;

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.CompareTag("fuse"))
        {

            onTriggerEnter.Invoke();
        }



        

    }




}
