using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Layout2 : MonoBehaviour
{

    [SerializeField] RectTransform rectTransformPadre;
    [SerializeField] Image[] img;
    private void Awake()
    {
        if (img.Length ==0) throw new Exception("A�ade imagenes tolai");
        if (rectTransformPadre == null) throw new Exception("A�ade el rectTransform tolai");
        foreach (var image in img)
        {
            image.transform.SetParent(rectTransformPadre.transform);
        }
    }
}
