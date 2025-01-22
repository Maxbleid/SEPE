using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Componentes6 : MonoBehaviour
{
    [SerializeField] GameObject[] arraycomponentes6;
    private void Awake()
    {
        if (arraycomponentes6.Length == 0)
        {
            throw new Exception("ERRO: EL ARRAY ESTA VACIO");
        }
        //foreach (GameObject desactivar in arraycomponentes6)
        //{
        //    desactivar.SetActive(false);
        //}
        foreach (GameObject go in arraycomponentes6)
        {
            go.SetActive(false);
            if (!go.GetComponent<Rigidbody2D>())
            {
                Debug.Log($"{go.name} no tiene RigidBody2D");
            }
            else
            {
                go.SetActive(true);
            }
        }
    }
}
