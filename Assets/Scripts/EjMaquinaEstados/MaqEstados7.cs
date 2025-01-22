using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MaqEstados7 : MonoBehaviour
{

    [SerializeField] Button vidasMas;
    [SerializeField] Button vidasMenos;
    [SerializeField]  Image vidasImagen;
    [SerializeField] SpriteRenderer corazon;
    float initialWidth;
    [SerializeField] int numeroVidas;
    private void Awake()
    {
        numeroVidas = 3;
        vidasMas.GetComponentInChildren<TMP_Text>().text = "+";
        vidasMenos.GetComponentInChildren<TMP_Text>().text = "-";
        corazon.size = new Vector2(numeroVidas, 1);
        //initialWidth = vidasImagen.rectTransform.sizeDelta.x;            
        
    }

    public void VidasMas()
    {
        numeroVidas++;
        if (numeroVidas > 0)
        {
            //vidasImagen.rectTransform.sizeDelta = new Vector2(initialWidth * numeroVidas, vidasImagen.rectTransform.sizeDelta.y);
            corazon.size = new Vector2(numeroVidas, 1);
        }
       
    }

    public void VidasMenos()
    {
        if (numeroVidas <= 0)
        {
            //vidasImagen.rectTransform.sizeDelta =  new Vector2(initialWidth*0,vidasImagen.rectTransform.sizeDelta.y);
            corazon.size = new Vector2(numeroVidas, 1);
        }
        else
        {
            numeroVidas--;
            //vidasImagen.rectTransform.sizeDelta = new Vector2(initialWidth * numeroVidas, vidasImagen.rectTransform.sizeDelta.y);
            corazon.size = new Vector2(numeroVidas, 1);
        }
    }
    
}
