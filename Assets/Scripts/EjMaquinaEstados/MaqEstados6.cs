using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.UIElements;
using System;
using TMPro;
using UnityEngine.UI;

public class MaqEstados6 : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] TMP_InputField multiplicador;
    [SerializeField] Image corazon;
    float initialWidth;
    private void Awake()
    {
        initialWidth = corazon.rectTransform.sizeDelta.x; 
    }
    public void AsignarVidas()
    {
        int numeroVidas = int.Parse(multiplicador.text);
        if (numeroVidas > 0)
        {
            corazon.rectTransform.sizeDelta = new Vector2(initialWidth * numeroVidas, corazon.rectTransform.sizeDelta.y);
        }
        else
        {
           Debug.Log($"EL NUMERO DE VIDAS {multiplicador} DEBE SER POSITIVO");
        }
    }
}
