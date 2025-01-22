using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fountain : MonoBehaviour
{
    [SerializeField] Animator animator;

    private void Awake()
    {
        if (animator == null) throw new Exception("ERROR: olvidaste el animator");
    }

    public void Rojo()
    {
        animator.SetBool("sinAgua", false);
        animator.SetBool("aguaRoja", true);
        animator.SetBool("aguaAzul", false);
        //animator.SetTrigger("aguaRojaTrigger"); con este según como settemos el mute de los
        //valores, entonces no habria que desactivar las otras animaciones 
    }

    public void Azul()
    {
        animator.SetBool("sinAgua", false);
        animator.SetBool("aguaRoja", false);
        animator.SetBool("aguaAzul", true);
        //animator.SetTrigger("aguaAzulTrigger");
    }
    public void SinAgua()
    {
        animator.SetBool("sinAgua", true);
        animator.SetBool("aguaRoja", false);
        animator.SetBool("aguaAzul", false);
        //animator.SetTrigger("sinAguaTrigger");
    }
}
