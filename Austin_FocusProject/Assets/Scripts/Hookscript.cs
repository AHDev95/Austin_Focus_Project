using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Hookscript : MonoBehaviour
{
    [SerializeField]
    GameObject lockpoint;
    WaitForSeconds delay = new WaitForSeconds(2);
    [SerializeField]
    Rigidbody hookBody;
    [SerializeField]
    float speed;
    [SerializeField]
    GameObject gun;
    [SerializeField]
    GameObject XRRig;
    bool Hook = false;
    [SerializeField]
    private UnityEvent hookfired;
    [SerializeField]
    private UnityEvent hookreturn;


    //bool dontHook = false;
    public void fire()
    {
        gameObject.transform.parent = null;
        hookBody.isKinematic = false;
        hookBody.AddForce(-gun.transform.up * speed, ForceMode.Impulse); //push the hook forward time value of speed
        hookfired.Invoke();
        StartCoroutine(fireTimer());
        Debug.Log("end of fire function");
    }


    void OnCollisionEnter(Collision other) //when another collider passes through check if it is hookable
    {
        hookBody.velocity = Vector3.zero;
        hookBody.isKinematic = true;

        if (other.gameObject.CompareTag("Hookable"))//check for  tag
        {
             Debug.Log("hit");
            
            hookBody.velocity = Vector3.zero;
            hookBody.isKinematic = true;
            Hook = true;
           
           
        }
       else if (other.gameObject.CompareTag("NotHookable"))
        {
            hookBody.velocity = Vector3.zero;
            hookBody.isKinematic = true;

            transform.position = lockpoint.transform.position;
            transform.rotation = lockpoint.transform.rotation;
            gameObject.transform.parent = gun.transform;
            hookreturn.Invoke();
            
        } /**/

    }


    public IEnumerator fireTimer()
    {   Debug.Log("start reset");
        yield return delay;


       
        if (Hook) // if true start to move player to location 
        {
            hookBody.isKinematic = true; 

            yield return delay;
            StartCoroutine(XRRig.GetComponent<GrappleMoveScript>().GrappleLoco());

            if (transform.position != lockpoint.transform.position)
            {


                transform.position = lockpoint.transform.position;
                transform.rotation = lockpoint.transform.rotation;
                gameObject.transform.parent = gun.transform;
                hookreturn.Invoke();

            }
            Debug.Log("Hit hookable wall");
            
            Hook = false;
            yield break;
        }
       
        else if (transform.position != lockpoint.transform.position)
        {


            hookBody.isKinematic = true;
            transform.position = lockpoint.transform.position;
            transform.rotation = lockpoint.transform.rotation;
            gameObject.transform.parent = gun.transform;
            hookreturn.Invoke();
        } 
       Debug.Log(" reset");
        yield break;
    }
   
}
