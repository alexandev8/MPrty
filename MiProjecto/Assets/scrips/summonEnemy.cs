using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class summonEnemy : MonoBehaviour
{
    public GameObject enemy, blockT1, blockT2, blockF3;
    public Collider collision;
    public bool blocks;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            enemy.SetActive(true);
            if (blocks == true)
            {
                blockT1.SetActive(true);
                blockT2.SetActive(true);
                blockF3.SetActive(false);
            }
            collision.enabled = false;
        }
    }
}

