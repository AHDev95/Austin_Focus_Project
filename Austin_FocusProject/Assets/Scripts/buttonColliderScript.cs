using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buttonColliderScript : MonoBehaviour
{
    [SerializeField]
    GameObject button;



    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("pressed");
        if (other.gameObject.CompareTag("FingerTip"))
        {
            button.GetComponent<Button>().onClick.Invoke();
        }
    }
}
