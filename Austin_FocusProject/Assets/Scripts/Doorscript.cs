using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doorscript : MonoBehaviour
{
    [SerializeField]
    GameObject DoorOBJ;
    [SerializeField]
    float doorMove = 3;

   /* public void Start()
    {
        DoorOBJ.transform.Translate(Vector3.forward * doorMove);
        Debug.Log("opens");
    }*/
    public void Opendoor()
    {
        DoorOBJ.transform.Translate(Vector3.forward * doorMove);


    }

}
