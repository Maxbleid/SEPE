using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;
using System;

public class Componentes4 : MonoBehaviour
{

    [SerializeField] GameObject componentes4;
    Rigidbody2D componentes4RGBody;
    private void Awake()
    {
        if (componentes4 != null && componentes4.GetComponent<Rigidbody2D>() !=null)
        {
           componentes4RGBody = componentes4.GetComponent<Rigidbody2D>();
            componentes4RGBody.gravityScale = 10f;
        }
        else
        {
            throw new Exception("El componente no tiene Rigidbody2D");
        }
    }
}
