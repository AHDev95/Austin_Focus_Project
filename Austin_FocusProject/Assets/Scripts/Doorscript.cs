using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class Doorscript : MonoBehaviour
{
   // [SerializeField]
   // GameObject DoorOBJ;
   // [SerializeField]
   // float doorMove = 3;
    public float smoothing = 1f;
    [SerializeField]
    Transform openPosition;
    [SerializeField]
    private UnityEvent audio;
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
        audio.Invoke();

        while (Vector3.Distance(transform.position, openPosition.position) > 0.05f)
        {    
            transform.position = Vector3.Lerp(transform.position, openPosition.position, smoothing * Time.deltaTime);

            yield return null;
        }
 
    }
}
