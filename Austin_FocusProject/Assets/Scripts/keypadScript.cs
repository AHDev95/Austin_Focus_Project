using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class keypadScript : MonoBehaviour
{
    public int[] rightcode;
    public int[] enterCode;
    public int count = 0;
    GameObject switchHandel;
   [SerializeField]
   private UnityEvent grabInterActive;
    public void checkcode()
    {
       //Debug.Log("checking");
       for (int i = 0; i < enterCode.Length; i++){ 

        if(rightcode[i] == enterCode[i])
        {
                //bool == true 
                grabInterActive.Invoke();
                
                //Debug.Log("right code!!!!!!!!!!");
                //play right guess clip
        }
        else
        {  
            enterCode[i] = 0;
           
            count = 0;

               // Debug.Log("wrong code!!!!!!!");
                //and play wrong guess clip
        }

         }
    }



}
