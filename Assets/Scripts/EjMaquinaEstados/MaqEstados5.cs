using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class MaqEstados5 : MonoBehaviour
{
    [SerializeField] TMP_Text m_Text;
    [SerializeField] Button m_vidasMas;
    [SerializeField] Button m_vidasMenos;
    [SerializeField] int vidas = 1;
    private void Awake()
    {
        if (m_Text == null) throw new Exception("ERROR: olvidaste el texto");
        m_Text.text = $"Vidas: {vidas}";
        m_vidasMas.GetComponentInChildren<TMP_Text>().text = "+";
        m_vidasMenos.GetComponentInChildren<TMP_Text>().text = "-";
    }

    public void VidasMas()
    {
        if (vidas > 0 && vidas < 3)
        {
            vidas++;
            m_Text.text = $"Vidas: {vidas}";
        }
        else if (vidas >= 3)
        {
            m_Text.text = "Has llegado al máximo de vidas";
        }
    }

    public void VidasMenos()
    {
        if ( vidas > 0)
        {
            vidas--;
            m_Text.text = $"Vidas: {vidas}";
        }
        else if (vidas == 0)
        {
            m_vidasMas.enabled = false;
            m_vidasMas.gameObject.SetActive(false);
            vidas--;
            m_Text.text = "HAS MUERTO";
        }
        else 
        {
            m_Text.text = "NO ENTIENDES QUE HAS MUERTO??";
        }
    }
}
