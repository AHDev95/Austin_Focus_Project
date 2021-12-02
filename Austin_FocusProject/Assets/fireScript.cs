using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.InputSystem;


public class fireScript : MonoBehaviour
{
    private XRGrabInteractable grabInter;
    [SerializeField]
    GameObject hook;
    bool cooldown = true;
    WaitForSeconds cooling = new WaitForSeconds(2);




    private void Awake()
    {
        grabInter = GetComponent<XRGrabInteractable>();
        grabInter.activated.AddListener(HookShot);
        
    }

    private void HookShot(ActivateEventArgs arg0)
    {
        if (cooldown)
        {
            hook.GetComponent<Hookscript>().fire();
            cooldown = false;
            StartCoroutine(CoolDownTimer());
        }

    }
    IEnumerator CoolDownTimer()
    {
        yield return cooling;
       // Debug.Log("cooling");
        cooldown = true;
    }

}
