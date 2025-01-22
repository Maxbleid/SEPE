using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using System;
public class Open_Close_Chest : MonoBehaviour
{
    [SerializeField] Animator animator;
    private void Awake()
    {
        if (animator == null) throw new Exception("ERROR: olvidaste el animator");
        animator.SetBool("Open", false);
        animator.SetBool("Close", false);
    }

    public void AbrirCofre()
    {
        animator.SetBool("Open", true);
        animator.SetBool("Close", false);
    }

    public void CerrarCofre()
    {
        animator.SetBool("Open", false);
        animator.SetBool("Close", true);
    }
}
