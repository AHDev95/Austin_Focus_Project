using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.InputSystem;
using System;

public class flipTheSwitch : MonoBehaviour
{



    private XRBaseInteractable grabInter;
    HingeJoint hinge;
    [SerializeField]
    GameObject Door1;
    [SerializeField]
    GameObject Door2;
    //[SerializeField]
    //int inputVariable = -80 ;
    //bool onOff = true;
    // Start is called before the first frame update
   private void Awake() 
    {
        //Debug.Log("started");
        hinge = GetComponent<HingeJoint>();
        grabInter = GetComponent<XRGrabInteractable>();
        grabInter.selectEntered.AddListener(openUp);
    }

    private void openUp(SelectEnterEventArgs arg0)
    {
        if (hinge.angle >= hinge.limits.max)
        {
            Door1.GetComponent<Doorscript>().Opendoor();
            Door2.GetComponent<Doorscript>().Opendoor();

        }
    }

   
       
        //StartCoroutine(opensesame());
    

  /*  public IEnumerator opensesame()
    {
        while (onOff)
        {
            if (hinge.angle >= hinge.limits.max)
            {
                Door1.GetComponent<Doorscript>().Opendoor();
                Door2.GetComponent<Doorscript>().Opendoor();
                
                onOff = false;
                yield break;
            }
            yield return null;
        }
    }




//hinge.transform.rotation = Quaternion.Euler(inputVariable, 0, 0);




    

    // Update is called once per frame
    void Update()
    {
        if (hinge.angle >= hinge.limits.max)
        {
            Door1.GetComponent<Doorscript>().Opendoor();
            Door2.GetComponent<Doorscript>().Opendoor();
            
        }
    } */ 
}
