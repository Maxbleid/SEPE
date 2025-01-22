using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjRecursividad3 : MonoBehaviour
{
    [SerializeField] int numero;
    int suma;
    // Start is called before the first frame update
    private void Awake()
    {
        suma = 0;
    }
    void Start()
    { 
        SumaRecursivaNumeros(1);
    }

    private void SumaRecursivaNumeros(int numero)
    {
        if (numero > this.numero)
        {
            Debug.Log(suma);
            return;
        }
        suma += numero;
        //Debug.Log(suma);
        SumaRecursivaNumeros(numero + 1);
    }
}
