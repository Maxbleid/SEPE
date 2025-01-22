using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasDropdown : MonoBehaviour
{
    [SerializeField] RectTransform m_rectLayout;
    [SerializeField] Image[] m_images;
    int selectedIndex                       ;
    private void Awake()
    {
        if (m_images.Length == 0) throw new Exception("ERROR: array vacio");
        if (m_rectLayout == null) throw new Exception("ERROR: te has olvidado el rectTransform");
    }
    public void AddChest()
    {
        Debug.Log($"Añado cofre tipo {selectedIndex}");
        Instantiate(m_images[selectedIndex],m_rectLayout);
    }
   public void OnValueChange(Int32 newValue)
    {
          selectedIndex = newValue;
    }
}
