using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjRecursividad4 : MonoBehaviour
{
    [SerializeField] int numero;
    [SerializeField] int potencia;
    int index=0;
    // Start is called before the first frame update
    void Start()
    {
        PotenciaRecursiva(numero, index);
    }

    private void PotenciaRecursiva(int numero, int index)
    {
       if (numero == 0) 
       {
            Debug.Log($"El numero 0 elevado a cualquier potencia es 0");
            return; 
       }
       else if (index > potencia)
        {
            return;
        }
        Debug.Log($"El numero {numero} elevado  a {index} es igual a: {Mathf.Pow(numero,index)}");
        PotenciaRecursiva(numero, index+1);
    }
}
