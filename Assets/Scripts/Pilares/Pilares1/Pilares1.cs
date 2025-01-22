using System.Collections;
using System.Collections.Generic;
using Unity.PlasticSCM.Editor.WebApi;
using UnityEngine;

public class Pilares1 : MonoBehaviour
{
    ISoundMaker soundMaker;

    private void Awake()
    {
        soundMaker = new Crow();
        soundMaker.MakeSound();
        soundMaker = new Duck(5); //podemos tener constructores con o sin parámetros
        soundMaker.MakeSound();
        soundMaker = new Owl();
        soundMaker.MakeSound();
    }
}
