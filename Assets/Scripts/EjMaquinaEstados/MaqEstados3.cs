using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using System;
using UnityEngine.TextCore.Text;
public class MaqEstados3 : MonoBehaviour
{
    public enum EstadoThread
    {
        EsperandoCreacion, Ejecutando, Finalizada, EsperandoElimnacion, Eliminado
    }

    [SerializeField] TMP_Text tMP_Text;
    EstadoThread estadoHilo = EstadoThread.EsperandoCreacion;   
    private void Awake()
    {
        tMP_Text.textStyle = TMP_Settings.defaultStyleSheet.GetStyle("Quote");
     if(tMP_Text ==null)
        {
            throw new Exception("ERROR: Te falta el tmp_text");
            //tMP_Text.text = estadoHilo.ToString();  
        }   
    }
    // Update is called once per frame
    void Update()
    {
        switch (estadoHilo)
        {
            case EstadoThread.EsperandoCreacion:
                if (Input.GetKeyDown(KeyCode.C))
                {
                    estadoHilo = EstadoThread.Ejecutando;
                    tMP_Text.text = estadoHilo.ToString() ;
                }
                if (Input.GetKeyDown(KeyCode.N))
                {
                    estadoHilo = EstadoThread.Eliminado;
                    tMP_Text.text = estadoHilo.ToString();
                }
                break;
            case EstadoThread.Ejecutando:
                if (Input.GetKeyDown(KeyCode.F))
                {
                    estadoHilo = EstadoThread.Finalizada;
                    tMP_Text.text = estadoHilo.ToString();
                }
                if (Input.GetKeyDown(KeyCode.S))
                {
                    estadoHilo = EstadoThread.EsperandoElimnacion;
                    tMP_Text.text = estadoHilo.ToString();
                }
                if (Input.GetKeyDown(KeyCode.G))
                {
                    estadoHilo = EstadoThread.Eliminado;
                    tMP_Text.text = estadoHilo.ToString();
                }
                break;
            case EstadoThread.Finalizada:
                if (Input.GetKeyDown(KeyCode.E))
                {
                    estadoHilo = EstadoThread.EsperandoElimnacion;
                    tMP_Text.text = estadoHilo.ToString();
                }
                break;
            case EstadoThread.EsperandoElimnacion:
                if (Input.GetKeyDown(KeyCode.H))
                {
                    estadoHilo = EstadoThread.Eliminado;
                    tMP_Text.text = estadoHilo.ToString();
                }
                break;
            case EstadoThread.Eliminado:
                break;
        }
    }
}
