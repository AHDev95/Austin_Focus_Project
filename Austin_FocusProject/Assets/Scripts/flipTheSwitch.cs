using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flipTheSwitch : MonoBehaviour
{
    HingeJoint hinge;
    [SerializeField]
    GameObject Door;

    // Start is called before the first frame update
    void Start()
    {
        hinge = GetComponent<HingeJoint>();
    }

    // Update is called once per frame
    void Update()
    {
        if (hinge.angle == hinge.limits.max)
        {
            Door.GetComponent<Doorscript>().Opendoor(); 
        }
    }
}
