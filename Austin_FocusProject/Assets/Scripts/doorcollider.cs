using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorcollider : MonoBehaviour
{
    [SerializeField]
    GameObject Door;
    //Doorscript DoorOpen;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        { 
        Debug.Log("hit door");
        // DoorOpen.Opendoor();
        Door.GetComponent<Doorscript>().Opendoor();
        }
    }
}
