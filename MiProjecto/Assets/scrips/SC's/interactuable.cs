using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interactuable : MonoBehaviour
    //puerta
{
    //activa evento de camara

    //rayCast_Jugador = PlayerCasting
    [SerializeField] bool canOpen;
    [SerializeField] GameObject thePlayer;
    [SerializeField] GameObject theCam;
    [SerializeField] GameObject textOnScreen;
    [SerializeField] AudioSource LockedDoor;


    void Update()
    {
        if (canOpen == true)
        {

            if (Input.GetKeyDown(KeyCode.E))
            {
                Debug.Log("Puerta actua");
                StartCoroutine(OpeningDoor());
            }
        }
    }
    void OnMouseOver()
    {
        if (rayCast_Jugador.distanceFromTarget < 5)
        {
            canOpen = true;
            UIController.actionText = "Open Door";
            UIController.commandText = "Open";
            UIController.uiActive = true;
        }
        else
        {
            canOpen = false;
            UIController.actionText = "";
            UIController.commandText = "";
            UIController.uiActive = false;
        }

    }

    void OnMouseExit()
    {
        canOpen = false;
        UIController.actionText = "";
        UIController.commandText = "";
        UIController.uiActive = false;
    }
    IEnumerator OpeningDoor()
    {
        theCam.SetActive(true);
        thePlayer.SetActive(false);
        textOnScreen.SetActive(true);
        //LockedDoor.Play();
        yield return new WaitForSeconds(3);
        textOnScreen.SetActive(false);
        thePlayer.SetActive(true);
        theCam.SetActive(false);
    }

}
