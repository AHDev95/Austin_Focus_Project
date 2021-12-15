using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PitReturn : MonoBehaviour
{
    [SerializeField]
    GameObject spawnPoint;
    [SerializeField]
    GameObject player;
    [SerializeField]
    GameObject keyitem1;
    [SerializeField]
    GameObject keyitem2;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            StartCoroutine(Respawnpoint());
        }

        if (other.gameObject.CompareTag("KeyItem"))
        {
            StartCoroutine(resetItem());
        }

    }

    public IEnumerator resetItem()
    {
        //Debug.Log("moveing");
        keyitem1.transform.position = spawnPoint.transform.position;
        keyitem2.transform.position = spawnPoint.transform.position;

        yield break;
    }

    public IEnumerator Respawnpoint()
    {
        //Debug.Log("moveing");
        player.transform.position = spawnPoint.transform.position;
        yield break;
    }
}
