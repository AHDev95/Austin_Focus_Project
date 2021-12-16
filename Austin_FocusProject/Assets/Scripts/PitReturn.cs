using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PitReturn : MonoBehaviour
{
    [SerializeField]
    GameObject PlayerspawnPoint;
    [SerializeField]
    GameObject ItemspawnPoint;
    [SerializeField]
    GameObject player;
    [SerializeField]
    GameObject keyitem1;
    [SerializeField]
    GameObject keyitem2;
    WaitForSeconds delay = new WaitForSeconds(1);

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            StartCoroutine(Respawnpoint());
        }

       /* if (other.gameObject.CompareTag("KeyItem"))
        {
            StartCoroutine(resetItem());
        }*/

    }

    

    public IEnumerator Respawnpoint()
    {
        //Debug.Log("moveing");
        player.transform.position = PlayerspawnPoint.transform.position;
        yield return delay;
        keyitem1.transform.position = ItemspawnPoint.transform.position;
        yield return delay;
        keyitem2.transform.position = ItemspawnPoint.transform.position;
    }
}
