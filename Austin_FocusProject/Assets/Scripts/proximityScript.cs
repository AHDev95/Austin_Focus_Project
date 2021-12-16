using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class proximityScript : MonoBehaviour
{

    bool Notification = false;
    [SerializeField]
    private UnityEvent proximityEnter;
    [SerializeField]
    private UnityEvent proximityExit;

    private void OnTriggerEnter(Collider other) //when the tablet enters the area push a note
    {
       if (other.gameObject.CompareTag("KeyItem"))
            { 
       
            if (!Notification)
        {  //control panel conection not found. check power supply

            //Debug.Log("push note");

                proximityEnter.Invoke();

                
        }
        
        }
    }



    private void OnTriggerExit(Collider other) //when the tablet enters the area push a note
    {
        if (other.gameObject.CompareTag("KeyItem"))
        {

            if (!Notification)
            {  //control panel conection not found. check power supply

                //Debug.Log("push note");

                proximityExit.Invoke();

                
            }

        }
    }

}
