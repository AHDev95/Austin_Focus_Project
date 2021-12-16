using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class dockScript : MonoBehaviour
{
    [SerializeField]
    private UnityEvent dockTablet;
    [SerializeField]
    private UnityEvent TabletUpdate;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("KeyItem"))
        {
            dockTablet.Invoke();
            TabletUpdate.Invoke();
        }
    }
}
