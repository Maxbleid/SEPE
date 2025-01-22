using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using System;
public class Componentes7 : MonoBehaviour
{
    [SerializeField] GameObject objeto1;
    [SerializeField] GameObject objeto2;
    Vector3 position1;
    Vector3 position2;
    Vector3 position3 = new Vector3(0,0,0);
    private void Awake()
    {
        if (objeto1 == null || objeto2 == null) throw new Exception("ERROR: objeto no valido");

        position1 = objeto1.transform.position;
        position2 = objeto2.transform.position;

        position3 = objeto2.transform.position;

        objeto2.transform.position = position1;
        objeto1.transform.position = position3;

    }
}
