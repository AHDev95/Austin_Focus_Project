using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrappleMoveScript : MonoBehaviour
{

    [SerializeField]
    GameObject hookOffset;


    public IEnumerator GrappleLoco()
    {
        //Debug.Log("moveing");
        transform.position = hookOffset.transform.position;
        yield break;
    }
}
