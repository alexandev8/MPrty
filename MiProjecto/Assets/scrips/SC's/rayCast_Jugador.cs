using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rayCast_Jugador : MonoBehaviour
{
    //castea rayo
    public static float distanceFromTarget;
    [SerializeField] float toTarget;


    void Update()
    {

        RaycastHit Hit;
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out Hit))
        {

            toTarget = Hit.distance;
            distanceFromTarget = toTarget;
        }
    }
}
