using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Componentes1 : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] GameObject[] gameObjects;
    private void Awake()
    {
        if (gameObjects.Length ==0 || gameObjects == null)
        {
            throw new Exception("ERROR: ARRAY VACIO");
        }
        foreach (var go in gameObjects) 
        {
            go.SetActive(false);
        }
        gameObjects[0].SetActive(true);
        gameObjects[gameObjects.Length-1].SetActive(true);

    }
}
