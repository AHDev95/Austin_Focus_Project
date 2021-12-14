using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doorscript : MonoBehaviour
{
   // [SerializeField]
   // GameObject DoorOBJ;
   // [SerializeField]
   // float doorMove = 3;
    public float smoothing = 1f;
    [SerializeField]
    Transform openPosition;
   /* public void Start()
    {
        DoorOBJ.transform.Translate(Vector3.forward * doorMove);
        Debug.Log("opens");
    }*/
    public void Opendoor()
    {
       // DoorOBJ.transform.Translate(Vector3.forward * doorMove);

        StartCoroutine(doorOpen());
    }


    IEnumerator doorOpen()
    {


        while (Vector3.Distance(transform.position, openPosition.position) > 0.05f)
        {
            transform.position = Vector3.Lerp(transform.position, openPosition.position, smoothing * Time.deltaTime);

            yield return null;
        }
 
    }
}
