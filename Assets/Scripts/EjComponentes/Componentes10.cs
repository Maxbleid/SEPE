using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Unity.VisualScripting;

public class Componentes10 : MonoBehaviour
{
    [SerializeField] SpriteRenderer[] arrayComponentes10;
    [SerializeField] Color[] coloresComponentes10;

    private void Awake()
    {
        if (arrayComponentes10.Length != coloresComponentes10.Length || arrayComponentes10.Length==0)
        {
            throw new Exception("El tamaño de los arrays no coincide");
        }

        for (int i = 0; i < arrayComponentes10.Length; i++) 
        {
            arrayComponentes10[i].color = coloresComponentes10[i];
        }

    }
}
