using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyInputScript : MonoBehaviour
{ 
    [SerializeField]
    keypadScript KS;
    [SerializeField]
    int buttonNumber;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("FingerTip")) //when the index finger enters trigger
        {
            //Debug.Log("button pressed");
          if (KS.count < 4) // only if the count is less than 4
           { 
             KS.enterCode[KS.count] = buttonNumber; //fill element that matches the count 
             KS.count++;//add to count
            if (KS.count == 4)//whe count = 4 run checkcode function in keyPadScript
            {
                KS.checkcode();
            }
            
           }
        }
    }


   
}
