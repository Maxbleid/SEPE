using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjRecursividad2 : MonoBehaviour
{
    [SerializeField] string frase;
    
    private void Awake()
    {
        LetrasTexto(0);        
    }// podemos poner la recursividad en el start si queremos que se "pinte" despues

    private void LetrasTexto(int index)
    {
        
        if (index == frase.Length)
        {
            return;
        }
        Debug.Log(frase[index]);
        LetrasTexto(index + 1);
    }
}
