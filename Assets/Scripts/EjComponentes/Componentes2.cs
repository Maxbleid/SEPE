using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Componentes2 : MonoBehaviour
{
    [SerializeField] GameObject[] arrayGameObjects;
    // Start is called before the first frame update
    private void Awake()
    {
        if (arrayGameObjects == null || arrayGameObjects.Length == 0)
        {
            throw new Exception("ERROR: ARRAY VACIO");
        }
        //foreach (var go in arrayGameObjects)
        //{
        //    go.SetActive(false);
        //}
        for (int i = 0; i < arrayGameObjects.Length; i++) 
        {
            //if (i % 2 == 0)
            //{
            //    arrayGameObjects[i].SetActive(true);
            //}
            //else
            //{
            //    arrayGameObjects[i].SetActive(false);
            //}

            arrayGameObjects[i].SetActive(i % 2 == 0);
        }
    }
}
