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
    bool Hit = false;
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
            Hit = true;
            /*StartCoroutine(HookableWall());
            if (other.gameObject.CompareTag("Hookable"))//check for keystone tag
            {
                Hit = true;
                StartCoroutine(HookableWall());*/
        }
       /* else if (other.gameObject.CompareTag("NotHookable"))
        {
            hookBody.velocity = Vector3.zero;

            StartCoroutine(wall());
        }*/

    }


    public IEnumerator fireTimer()
    {   Debug.Log("start reset");
        yield return delay;

        //if hit is true start coroutine hookableNothookable yield break 

        if (Hit)
        {
            StartCoroutine(HookableWall());
            Hit = false;
            yield break;
        }
      if (transform.position != lockpoint.transform.position)
        {


            hookBody.isKinematic = true;
            transform.position = lockpoint.transform.position;
            transform.rotation = lockpoint.transform.rotation;
            gameObject.transform.parent = gun.transform;

        } /* */
       Debug.Log(" reset");
        yield break;
    }

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
    
}
