using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;
using Unity.VisualScripting;

public class CanvasEj2 : MonoBehaviour
{
    // Start is called before the first frame update


    [SerializeField] int numero;
    [SerializeField] TMP_Text tmp_texto;

    private void Awake()
    {
        if (tmp_texto == null) 
        {
            throw new Exception("ERROR:Null pointer");
        }
        else if (Espar(numero))
        {
            tmp_texto.text = ($"El numero {numero} SI es multiplo de 2");
        }
        else
        {
            tmp_texto.text = ($"El numero {numero} NO es multiplo de 2");
        }
    }
    private bool Espar(int num)
    {
        return num % 2 == 0;
    }
}
