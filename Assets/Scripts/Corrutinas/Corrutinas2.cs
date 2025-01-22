using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;



public class Corrutinas2 : MonoBehaviour
{
    [SerializeField] new Renderer renderer;
    [SerializeField, Range (0f,1f)] float opacidad;
    [SerializeField] float m_tiempoFlicker = 3f;
    [SerializeField, Range(0.05f, 1f)] float delay = 0.2f;
    private void Awake()
    {
        if (renderer == null) throw new Exception("ERROR: olvidaste el renderer");
        StartCoroutine(Flicker());
    }
    IEnumerator Flicker()
    {
        var endTime = Time.time + m_tiempoFlicker;
        while (Time.time < endTime) 
        {
            if (opacidad <= 0.1f)
            {
                for (float num = 0f; num <= 1f; num += 0.1f)
                {
                    Color c = renderer.material.color;
                    c.a = num;
                    renderer.material.color = c;
                    yield return new WaitForSeconds(delay);
                }
                opacidad = renderer.material.color.a;
            }
            else if (opacidad >= 0.9f)
            {
                for (float num = 1f; num >= 0; num -= 0.1f)
                {
                    Color c = renderer.material.color;
                    c.a = num;
                    renderer.material.color = c;
                    yield return new WaitForSeconds(delay);
                }
                opacidad = renderer.material.color.a;
            }
           
        }
    }
}
