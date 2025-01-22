using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Linq;


public class Layout1 : MonoBehaviour
{
    // HORIZONTAL LAYOUT GROUP

    [SerializeField] RectTransform rectTransformPadre;
    [SerializeField] Image img;
    List<Image> imagesList;
    private void Awake()
    {
        if (img == null) throw new Exception("Añade el prefab tolai");
        if (rectTransformPadre == null) throw new Exception("Añade el rectTransform tolai");
        imagesList = new List<Image>();
        for (int i = 0; i <3; i++) 
        {
            AddPrefab();
        }
    }

    public void AddPrefab()
    {
        //debemos declarar la posición y el rectTransformPadre donde queremos instanciarlo, sino lo instacia fuera del
        //canvas
     var imageClone = Instantiate(img,rectTransformPadre);
        imagesList.Add(imageClone);
    }

    public void SubstractPrefab() 
    {
        if (imagesList.Count == 0 )
        {
            throw new Exception("YA HAS ELIMINADO TODO");
        }
        else
        {
            var image = imagesList[0];
            imagesList.Remove(imagesList[0]); //con esto quito la imagen de la lista, desaparece visualmente pero no el gameobject
            Destroy(image.gameObject); //con esto destruimos el gameobject en si 
        }
      
    }
}
