using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorPlay : MonoBehaviour
{
    [SerializeField] AudioSource pianoSound;
    [SerializeField] AudioSource doorSlam;
    [SerializeField] GameObject theDoor;

    void OnTriggerEnter(Collider other)
    {
        theDoor.GetComponent<Animator>().Play("animDoor");
        //pianoSound.Play();
        //doorSlam.Play();
        this.GetComponent<BoxCollider>().enabled = false;
    }


}
