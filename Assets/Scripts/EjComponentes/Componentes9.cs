using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Componentes9 : MonoBehaviour
{
    [SerializeField] GameObject[] arrayComponentes9;

    private void Awake()
    {
        if (arrayComponentes9.Length == 0)
        {
            throw new Exception("ERROR: EL ARRAY ESTA VACIO");
        }
        foreach (GameObject desactivar in arrayComponentes9) 
        {
           desactivar.SetActive(false); 
        }
        foreach(GameObject circulo in arrayComponentes9)
        {
            if (!circulo.GetComponent<SpriteRenderer>()||circulo.GetComponent<SpriteRenderer>().name!="Circle")
            {
                Debug.Log($"{circulo.name} no tiene un spriterenderer 'Circle'");
            }
            else if ( circulo.GetComponent<SpriteRenderer>().sprite.name.Contains("Circle"))
            {
                circulo.SetActive(true);
            }
        }
    }
}
