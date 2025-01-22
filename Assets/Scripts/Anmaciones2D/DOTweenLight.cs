using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class DOTweenLight : MonoBehaviour
{
  
    [SerializeField] float lightIntesityFinal = 2f;
    [SerializeField] float lightIntensityDuration = 3f;

    [SerializeField] Ease ease;
    new Light light;

    private void Awake()
    {
        light = GetComponent<Light>();
        light.DOIntensity(lightIntesityFinal, lightIntensityDuration).SetEase(ease);
    }
}
