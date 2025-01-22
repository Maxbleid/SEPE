using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class Componentes5 : MonoBehaviour
{
    [SerializeField] GameObject[] arrayComponentes5;
    SpriteRenderer arraycomp5object;
    private void Awake()
    {
        arraycomp5object = GetComponent<SpriteRenderer>();
        foreach (var comp in arrayComponentes5)
        {
            comp.SetActive(false);
        }
        if (arrayComponentes5.Length == 0)
        {
            throw new Exception("ERROR: ARRAY VACIO");
        }
        for (int i = 0; i < arrayComponentes5.Length; i++)
        {

           if (arrayComponentes5[i].GetComponent<SpriteRenderer>() != null)
            {
                arrayComponentes5[i].SetActive(true);
            }
            else
            {
                Debug.Log($"El objeto {arrayComponentes5[i].name} no tiene SpriteRenderer");
            }
        }
    }
}
