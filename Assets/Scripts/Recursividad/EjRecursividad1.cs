using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjRecursividad1 : MonoBehaviour
{
    [SerializeField] int numFinal;
    private void Awake()
    {
        NumerosRecursivos(1);
    }


    //es recursivo ya que para avanzar se llama a si mismo.
    private void NumerosRecursivos(int numero)
    {
        Debug.Log(numero);
        if (numero == this.numFinal) 
        {
            Debug.Log(numero);
            return;
        }
        NumerosRecursivos(numero+1);
    }
}
