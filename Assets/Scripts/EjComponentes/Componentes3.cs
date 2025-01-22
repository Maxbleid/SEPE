using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Componentes3 : MonoBehaviour
{
    [SerializeField] Rigidbody2D[] arrayObjectsRigidbody2D;
    // Start is called before the first frame update
    private void Awake()
    {
        if (arrayObjectsRigidbody2D == null || arrayObjectsRigidbody2D.Length == 0)
        {
            throw new Exception("ERROR: ARRAY VACIO");
        }


        for (int i = 0; i < arrayObjectsRigidbody2D.Length; i++) 
        {
            arrayObjectsRigidbody2D[i].gameObject.SetActive(i%3==0);
        }
    }
}
