using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camaras2 : MonoBehaviour
{
    //Crear una animación de shake a la cámara y al presionar un boton
    //debe realizarse dicha animacion
    [SerializeField] float duration = 2f;
    [SerializeField] float intensity = 0.5f;
    Camera camara;
    private void Awake()
    {
        camara = Camera.main;
        StartCoroutine(ShakeCoroutine());
    }

    IEnumerator ShakeCoroutine()
    {
        float time = 0f;
        Vector3 newPosition;
        Vector2 randomPosition;
        Vector3 initialPosition = camara.transform.position;
        while(time < duration)
        {
            randomPosition = UnityEngine.Random.insideUnitCircle * intensity;
            newPosition = new Vector3(randomPosition.x, randomPosition.y, camara.transform.position.z);
            
            camara.transform.position = Vector3.Lerp(camara.transform.position, newPosition, Time.deltaTime); 
            time += Time.deltaTime;
            yield return null;
        }
        //recuperamos la posicion inicial de la camara
        camara.transform.position = initialPosition;
        Debug.Log($"he esperado {time} segundos");
    }
}
