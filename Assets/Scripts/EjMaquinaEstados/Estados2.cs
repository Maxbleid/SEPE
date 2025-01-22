using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Estados2 : MonoBehaviour
{
    // Implementar un programa que cumpla el diseño dado por este diagrama de estados
    //      La cantidad solicitada la modificará el usuario en una variable del Script
    //      Cada evento se definirá por la pulsación de una tecla
    //          P procesar
    //          A aceptar
    //          R rechazar
    //          D depositar al cliente
    //      Salvo el de “monto pagado” que consistirá en añadir una cantidad definida por el usuario en un InputField y un botón
    //      Una vez pulsado se reinicia a 0
    //      El botón y el InputField se activa en el estado Entregado
    //      Una vez superada o igualada la cantidad solicitada se cambiará al estado Pagado
    //      El estado actual siempre debe mostrarse en un texto

    public enum EstadoPrestamo
    {
        Solicitado, EnRevisión, Cancelado, Autorizado, Entregado, Pagado
    }

    [SerializeField, Min(1)] int cantidadSolicitada = 5000;
    [SerializeField] TMP_Text tMP_Text;
    [SerializeField] Button button;
    [SerializeField] TMP_InputField tMP_InputField;
    EstadoPrestamo estadoPrestamo;

    private void Awake()
    {
        if (tMP_Text == null) throw new Exception("ERROR: olvidaste el texto");
        if (tMP_InputField == null) throw new Exception("ERROR: olvidaste el input");
        if (button == null) throw new Exception("ERROR: olvidaste el botón");

        // Desactivamos el botón y el InputField
        button.gameObject.SetActive(false);
        tMP_InputField.gameObject.SetActive(false);
        estadoPrestamo = EstadoPrestamo.Solicitado;
        tMP_Text.text = estadoPrestamo.ToString();
    }

    private void Update()
    {
        switch (estadoPrestamo)
        {
            case EstadoPrestamo.Solicitado:
                if (Input.GetKeyDown(KeyCode.P))
                {
                    estadoPrestamo = EstadoPrestamo.EnRevisión;
                    tMP_Text.text = estadoPrestamo.ToString();
                }
                break;
            case EstadoPrestamo.EnRevisión:
                if (Input.GetKeyDown(KeyCode.A))
                {
                    estadoPrestamo = EstadoPrestamo.Autorizado;
                    tMP_Text.text = estadoPrestamo.ToString();
                }
                if (Input.GetKeyDown(KeyCode.R))
                {
                    estadoPrestamo = EstadoPrestamo.Cancelado;
                    tMP_Text.text = estadoPrestamo.ToString();
                }
                break;
            case EstadoPrestamo.Autorizado:
                if (Input.GetKeyDown(KeyCode.D))
                {
                    estadoPrestamo = EstadoPrestamo.Entregado;
                    tMP_Text.text = estadoPrestamo.ToString();
                    // Activamos el botón y el inputfield
                    button.gameObject.SetActive(true);
                    tMP_InputField.gameObject.SetActive(true);
                }
                break;
            case EstadoPrestamo.Entregado:
                // Añadimos la devolución con el botón de enter
                if (Input.GetKeyDown(KeyCode.Return))
                {
                    DevolverPrestamo();
                }
                break;
        }
    }

    public void DevolverPrestamo()
    {
        Debug.Log(tMP_InputField.text);

        bool esNumero = Int32.TryParse(tMP_InputField.text, out int result); //TryPase, convierte el texto en
        //una variable 'out'
        if (esNumero)
        {
            if (result > 0)
            {
                // Debo actualizar cantidadSolicitada
                cantidadSolicitada -= result;
                // Si he devuelto todo paso al estado Pagado
                if (cantidadSolicitada <= 0)
                {
                    estadoPrestamo = EstadoPrestamo.Pagado;
                    tMP_Text.text = estadoPrestamo.ToString();

                    tMP_InputField.gameObject.SetActive(false);
                    button.gameObject.SetActive(false);
                }
            }
            else
            {
                Debug.Log("Debe ser un número positivo");
            }
        }
        else
        {
            Debug.Log("Debe ser un número");
        }
        tMP_InputField.text = "";
    }
}
