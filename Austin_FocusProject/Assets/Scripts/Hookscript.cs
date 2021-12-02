using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
    bool dontHook = false;
    public void fire()
    {
        gameObject.transform.parent = null;
        hookBody.isKinematic = false;
        hookBody.AddForce(-gun.transform.up * speed, ForceMode.Impulse);

        StartCoroutine(fireTimer());
        Debug.Log("end of fire function");
    }


    void OnCollisionEnter(Collision other) //when another collider passes through
    {
        if (other.gameObject.CompareTag("Hookable"))//check for  tag
        {
             Debug.Log("hit");

            hookBody.velocity = Vector3.zero;
            hookBody.isKinematic = true;
            Hook = true;
           // StartCoroutine(HookableWall());
           
        }
       else if (other.gameObject.CompareTag("NotHookable"))
        {
            hookBody.velocity = Vector3.zero;
            dontHook = true;
            //StartCoroutine(wall());
        } /**/

    }


    public IEnumerator fireTimer()
    {   Debug.Log("start reset");
        yield return delay;

        //if hit is true start coroutine hookableNothookable yield break 

        if (Hook)
        {
            hookBody.isKinematic = true;

            yield return delay;
            StartCoroutine(XRRig.GetComponent<GrappleMoveScript>().GrappleLoco());

            if (transform.position != lockpoint.transform.position)
            {


                transform.position = lockpoint.transform.position;
                transform.rotation = lockpoint.transform.rotation;
                gameObject.transform.parent = gun.transform;

                // resetHook = true;
                // Hit = false;
                // StopCoroutine("Fire");
            }
            Debug.Log("Hit hookable wall");
            //yield break;
            //StartCoroutine(HookableWall());
            Hook = false;
            yield break;
        }
        else if (dontHook)
        {
            hookBody.isKinematic = true;
            //yield return new WaitForSeconds(1); 
            if (transform.position != lockpoint.transform.position)
            {


                transform.position = lockpoint.transform.position;
                transform.rotation = lockpoint.transform.rotation;
                gameObject.transform.parent = gun.transform;

                // resetHook = true;
                // Hit = false;
                // StopCoroutine("Fire");
            }

            dontHook = false;
            yield break;
        }
        else if (transform.position != lockpoint.transform.position)
        {


            hookBody.isKinematic = true;
            transform.position = lockpoint.transform.position;
            transform.rotation = lockpoint.transform.rotation;
            gameObject.transform.parent = gun.transform;

        } /* */
       Debug.Log(" reset");
        yield break;
    }
    /*
    public IEnumerator HookableWall() //condense done to one coroutine
    {
        //StopCoroutine(fireTimer());
        hookBody.isKinematic = true;

        yield return delay;
        StartCoroutine(XRRig.GetComponent<GrappleMoveScript>().GrappleLoco());

        if (transform.position != lockpoint.transform.position)
        {


            transform.position = lockpoint.transform.position;
            transform.rotation = lockpoint.transform.rotation;
            gameObject.transform.parent = gun.transform;

            // resetHook = true;
            // Hit = false;
            // StopCoroutine("Fire");
        }
        Debug.Log("Hit hookable wall");
        yield break;
    }


    public IEnumerator wall()
    {
        StopCoroutine(fireTimer());
        hookBody.isKinematic = true;
        if (transform.position != lockpoint.transform.position)
        {


            transform.position = lockpoint.transform.position;
            transform.rotation = lockpoint.transform.rotation;
            gameObject.transform.parent = gun.transform;

            // resetHook = true;
            // Hit = false;
            // StopCoroutine("Fire");
        }
         Debug.Log("Hit wall");
        yield return null;
    }
    */
}
