using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class evento : MonoBehaviour
{
    //desaparece algo al tocarlo
    public GameObject boxHolder;
    void OnTriggerEnter(Collider other)
    {
        boxHolder.SetActive(false);
    }
}
