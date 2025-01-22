using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

// Creamos una enumeración con los estados

public class Estados1 : MonoBehaviour
{
    public enum EstadoTexto
    {
        Hola, Adiós
    }

    [SerializeField] TMP_Text tMP_Text;
    EstadoTexto estadoTexto;

    private void Awake()
    {
        estadoTexto = EstadoTexto.Hola;
        tMP_Text.text = estadoTexto.ToString();
    }

    public void CambiarTexto()
    {
        switch (estadoTexto)
        {
            case EstadoTexto.Hola:
                estadoTexto = EstadoTexto.Adiós;
                // tMP_Text.text = "Adiós";
                break;
            case EstadoTexto.Adiós:
                estadoTexto = EstadoTexto.Hola;
                // tMP_Text.text = "Hola";
                break;
        }
        tMP_Text.text = estadoTexto.ToString();
    }
}
