using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Diagnostics;

public class CanvasEj : MonoBehaviour
{
    [SerializeField] TMP_Text tmp_texto;
    [SerializeField] int numero;
    int sumaNumeros=0;
    private void Awake()
    {
        if (numero <0 || tmp_texto == null) 
        {
            throw new Exception("ERROR: numero negativo o sin TextMeshPro");
        }

        for (int i = numero; i > 0; i--) 
        {
            sumaNumeros += i;
        }
        tmp_texto.GetComponent<TMP_Text>().text =($"Dado el numero {numero}, la suma es {sumaNumeros}");
    }
}
