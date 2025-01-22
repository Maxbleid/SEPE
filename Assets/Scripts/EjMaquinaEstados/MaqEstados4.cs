using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MaqEstados4 : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] TMP_Text m_Text;
    EstadoSemaforo m_Estado;
    [SerializeField] Button m_Button;
    public enum EstadoSemaforo
    {
        Rojo, Ambar, Verde
    }
   public void CambiarColor()
    {
        switch (m_Estado)
        {
            case EstadoSemaforo.Rojo:
               
                m_Text.color = Color.green;
                m_Estado = EstadoSemaforo.Verde;
                m_Text.text = m_Estado.ToString();
                break;
            case EstadoSemaforo.Ambar:
                
                m_Text.color = Color.red;
                m_Estado = EstadoSemaforo.Rojo;
                m_Text.text = m_Estado.ToString();
                break;
            case EstadoSemaforo.Verde:
                
                m_Text.color = Color.yellow;
                m_Estado = EstadoSemaforo.Ambar;
                m_Text.text = m_Estado.ToString();
                break;
        }
    }
    private void Awake()
    {
        if (m_Text == null) throw new Exception("ERROR: olvidaste el texto");
        //Inicializamos el estado del semaforo inicial, en este caso Rojo
        m_Button.GetComponentInChildren<TMP_Text>().text = "CAMBIO";
        m_Estado = EstadoSemaforo.Rojo;
        m_Text.text = m_Estado.ToString();
        m_Text.color = Color.red;
    }
}
