using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class proximityScript : MonoBehaviour
{

    bool Notification = false;
    [SerializeField]
    private UnityEvent proximityEvent;

    private void OnTriggerEnter(Collider other) //when the tablet enters the area push a note
    {
       if (other.gameObject.CompareTag("KeyItem"))
            { 
       
            if (!Notification)
        {  //control panel conection not found. check power supply

            //Debug.Log("push note");

                proximityEvent.Invoke();

                Notification = true;
        }
        
        }
    }

}
