using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{

    public GameObject teleportTo = null;

    private GameObject player = null;

    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            TeleportPlayer();
        }
    }
    private void TeleportPlayer()
    {
        if (teleportTo != null)
        {
            if (transform.parent != null)
            {
                transform.parent.gameObject.SetActive(false);
                teleportTo.transform.parent.gameObject.SetActive(true);

                player.transform.position = teleportTo.transform.position;
            }
        }
    }
}