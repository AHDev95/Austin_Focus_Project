using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class SwitchHandsScript : MonoBehaviour
{
    XRGrabInteractable GrabInteractable;
    [SerializeField]
    Transform LeftHandGrab;
    [SerializeField]
    Transform RightHandGrab;
    [SerializeField]
    GameObject LeftHandInteractor;
    [SerializeField]
    GameObject RightHandInteractor;


    
    void Start()
    {
        GrabInteractable = GetComponent<XRGrabInteractable>();
    }

   public void SwapHand() //Mike's script foe swaping hands for interactibles
    {
        if (GrabInteractable.selectingInteractor.name == LeftHandInteractor.name)
        {
            GrabInteractable.attachTransform = LeftHandGrab;
        }
        if (GrabInteractable.selectingInteractor.name == RightHandInteractor.name)
        {
            GrabInteractable.attachTransform = RightHandGrab;
        }
    }
}
