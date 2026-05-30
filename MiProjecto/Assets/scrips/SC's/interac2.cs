using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interac2 : MonoBehaviour
    //quemar
{
    //quitar obstaculo
    [SerializeField] bool canBurn;
    [SerializeField] GameObject textOnScreen;
    [SerializeField] GameObject thePlayer;
    //
    [SerializeField] GameObject telaCam;
    [SerializeField] GameObject fadeIn;
    [SerializeField] GameObject flameObject;
    [SerializeField] GameObject telaObject;

    void Update()
    {
        if (canBurn == true)
        {

            if (Input.GetKeyDown(KeyCode.E))
            {

                this.GetComponent<BoxCollider>().enabled = false;
                StartCoroutine(telaArde());
            }
        }
    }
    void OnMouseOver()
    {
        if (rayCast_Jugador.distanceFromTarget < 5)
        {
            canBurn = true;
            UIController.actionText = "tela";
            UIController.commandText = "arder";
            UIController.uiActive = true;
        }
        else
        {
            canBurn = false;
            UIController.actionText = "";
            UIController.commandText = "";
            UIController.uiActive = false;
        }

    }

    void OnMouseExit()
    {
        canBurn = false;
        UIController.actionText = "";
        UIController.commandText = "";
        UIController.uiActive = false;
    }
    IEnumerator telaArde()
    {
        telaCam.SetActive(true);
        thePlayer.SetActive(false);

        flameObject.SetActive(true);
        //LockedDoor.Play();
        yield return new WaitForSeconds(3);

        fadeIn.SetActive(false);
        fadeIn.SetActive(true);
        telaObject.SetActive(false);
        flameObject.SetActive(false);
        thePlayer.SetActive(true);
        telaCam.SetActive(false);
    }

}
