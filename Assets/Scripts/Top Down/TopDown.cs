using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class TopDown : MonoBehaviour
{
  SpriteRenderer[] sortingArray;

    private void Awake()
    {
        sortingArray = GetComponentsInChildren<SpriteRenderer>();

        if (sortingArray.Length == 0) throw new Exception("ERROR: faltan los renderers");

        foreach (var sorting in sortingArray)
        {
            sorting.sortingOrder = (int)(-10 * sorting.transform.position.y);
        }
    }
}
