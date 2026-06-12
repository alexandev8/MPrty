using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camBob : MonoBehaviour
{
    public Animator cameraAnim;
    public bool walking;

    void Update()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
        {
            walking = true;
            cameraAnim.ResetTrigger("idel");
            cameraAnim.ResetTrigger("run");
            cameraAnim.SetTrigger("walk");
            if (walking == true)
            {
                if (Input.GetKey(KeyCode.LeftShift))
                {
                    cameraAnim.ResetTrigger("walk");
                    cameraAnim.ResetTrigger("idel");
                    cameraAnim.SetTrigger("run");
                }
            }
        }
        else
        {
            cameraAnim.ResetTrigger("walk");
            cameraAnim.ResetTrigger("run");
            cameraAnim.SetTrigger("idel");
            walking = false;
        }
    }
}
