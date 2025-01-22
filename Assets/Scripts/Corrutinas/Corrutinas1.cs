using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Corrutinas1 : MonoBehaviour
{
    [SerializeField, Range(1,50)] int numero= 10;
    [SerializeField] TMP_Text tMP_Text;
    [SerializeField, Range (0.05f,1f)] float delay = 0.2f;
    private void Awake()
    {
        if (tMP_Text == null) throw new Exception("ERROR: olvidaste el texto");
        StartCoroutine(MostrarNumero());
        
    }

    IEnumerator MostrarNumero()
    {
        for (int iterador = 0; iterador <= numero; iterador++)
        {
            tMP_Text.text = iterador.ToString();
            //yield return null; //parar durante el tiempo que dure 1 frame
            yield return new WaitForSeconds(delay);
        }
    }
}
