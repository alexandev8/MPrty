using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickupKey2 : MonoBehaviour
{
    public GameObject inttext, key, spookystuff;
    public AudioSource pickup;
    public bool interactable, scaryEvent;

    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            inttext.SetActive(true);
            interactable = true;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            inttext.SetActive(false);
            interactable = false;
        }
    }
    void Update()
    {
        if (interactable == true)
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                inttext.SetActive(false);
                interactable = false;
                //pickup.Play();
                if (scaryEvent == true)
                {
                    spookystuff.SetActive(true);
                }
                key.SetActive(false);
            }
        }
    }
}
