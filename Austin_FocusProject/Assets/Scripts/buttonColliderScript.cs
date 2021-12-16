using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buttonColliderScript : MonoBehaviour
{
    [SerializeField]
    GameObject button;



    private void OnTriggerEnter(Collider other) //interacting with the UI with collision instead of raycast 
    {
       Debug.Log("pressed");
        if (other.gameObject.CompareTag("FingerTip"))
        {
            button.GetComponent<Button>().onClick.Invoke();
        }
    }
}
