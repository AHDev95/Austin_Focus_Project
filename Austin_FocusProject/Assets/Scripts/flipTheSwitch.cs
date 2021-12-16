using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flipTheSwitch : MonoBehaviour
{
    HingeJoint hinge;
    [SerializeField]
    GameObject Door1;
    [SerializeField]
    GameObject Door2;

    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("started");
        hinge = GetComponent<HingeJoint>();
    }

    // Update is called once per frame
    void Update()
    {
        if (hinge.angle >= hinge.limits.max)
        {
            Door1.GetComponent<Doorscript>().Opendoor();
            Door2.GetComponent<Doorscript>().Opendoor(); 

        }
    }
}
