using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows.WebCam;

public class tomar : MonoBehaviour
    //pickUp
{
    //tomar algo
    [SerializeField] bool canPick;
    [SerializeField] GameObject textOnScreen;
    //
    [SerializeField] GameObject tableCandle;
    [SerializeField] GameObject handCandle;
    [SerializeField] GameObject telaEvento;


    void Update()
    {
        if (canPick == true)
        {

            if (Input.GetKeyDown(KeyCode.E))
            {

                this.GetComponent<BoxCollider>().enabled = false;
                tableCandle.SetActive(false);
                handCandle.SetActive(true);
                telaEvento.SetActive(true);

            }
        }
    }
    void OnMouseOver()
    {
        if (rayCast_Jugador.distanceFromTarget < 5)
        {
            canPick = true;
            UIController.actionText = "Candel";
            UIController.commandText = "pickUp";
            UIController.uiActive = true;
        }
        else
        {
            canPick = false;
            UIController.actionText = "";
            UIController.commandText = "";
            UIController.uiActive = false;
        }

    }

    void OnMouseExit()
    {
        canPick = false;
        UIController.actionText = "";
        UIController.commandText = "";
        UIController.uiActive = false;
    }
//

}
