using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Componentes8 : MonoBehaviour
{
    [SerializeField] GameObject sprite1;
    [SerializeField] GameObject sprite2;
    int spr1;
    int spr2;
    int sprcambio = 5;
    private void Awake()
    {
        if (sprite1.GetComponent<SpriteRenderer>() != null && sprite2.GetComponent<SpriteRenderer>() != null)
        {
            spr1 = sprite1.GetComponent<SpriteRenderer>().sortingOrder;
            spr2 = sprite2.GetComponent<SpriteRenderer>().sortingOrder;

            sprcambio = spr2;
            //Debug.Log(sprcambio);

            sprite2.GetComponent<SpriteRenderer>().sortingOrder = sprite1.GetComponent<SpriteRenderer>().sortingOrder;
            //Debug.Log(sprite2.GetComponent<SpriteRenderer>().sortingOrder);
            sprite1.GetComponent<SpriteRenderer>().sortingOrder = sprcambio;
            //Debug.Log(sprite1.GetComponent<SpriteRenderer>().sortingOrder);
        }
        else if (sprite1 == null || sprite2 == null) throw new Exception("ERROR: Alguno de los objetos no existe");
        else
        {
            throw new Exception("Al menos uno de los objetos no tiene SpriteRenderer");
        }
    }
}
