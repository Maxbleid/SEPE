using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class DOTweenAnimation : MonoBehaviour
{
    [SerializeField] Vector2 posicionFinal = new Vector2 (5,-1);
    [SerializeField] float duracionMovimiento = 3f;

    [SerializeField] AnimationCurve animationCurve;

    [SerializeField] Ease ease= Ease.InOutSine;

    [SerializeField] int loops = 2;
    private void Awake()
    {
        //al añadir el DOMove se esta usando el dotween y nos añade la biblioteca DG.Tweening automaticamente
        transform.DOMove(posicionFinal, duracionMovimiento).SetEase(ease).SetLoops(loops).OnComplete(OnCompleteCallBack);

        Vector3[] path = {posicionFinal, transform.position};
        transform.DOPath(path,3f);
    }

    private void OnCompleteCallBack()
    {
        Debug.Log("Termino");
    }
}
