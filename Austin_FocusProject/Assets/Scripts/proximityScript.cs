using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class proximityScript : MonoBehaviour
{

    bool Notification = false;

    private void OnTriggerEnter(Collider other) //when the tablet enters the area push a note
    {
       if (other.gameObject.CompareTag("tablet"))
            { 
       
            if (!Notification)
        {

            Debug.Log("push note");

            Notification = true;
        }
        
        }
    }

}
