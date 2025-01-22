using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.Assertions;


namespace Scripts.TocaPelotas
{

public class CoinDOTween : MonoBehaviour
{
        [SerializeField] Transform[] pathTransforms;
        [SerializeField] float duration = 3f;

        private void Awake()
        {
            Assert.IsTrue(pathTransforms.Length > 0, "ERROR: faltan puntos");
            Vector3[] path = new Vector3[pathTransforms.Length];
            for (int i = 0; i < pathTransforms.Length; i++)
            {
                path[i] = pathTransforms[i].position;
            }
            transform.DOPath(path, duration).SetEase(Ease.InElastic).OnComplete(OnDestroy);
           
        }

        private void OnDestroy()
        {
            DOTween.Kill(transform);
        }
    }
}
