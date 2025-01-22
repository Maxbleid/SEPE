using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjRecursividad5 : MonoBehaviour
{
   [SerializeField] int delay=6;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start");
      StartCoroutine(CorrutinasRecursivas(delay));
    }
    
    IEnumerator CorrutinasRecursivas(int espera) 
    {
        if (espera <= 0) 
        {
            Debug.Log("0 segundos de espera \n Fin");
            yield break;
        }

        Debug.Log($"Inicio dura {espera}");
        yield return new WaitForSeconds(espera);
        espera -= 2;
        Debug.Log("Fin");
        StartCoroutine(CorrutinasRecursivas(espera)); 
    }
}
