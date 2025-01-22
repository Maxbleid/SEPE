using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pilares2 : MonoBehaviour
{
    [SerializeField] AbstractSoundMaker abstractSoundMaker;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            abstractSoundMaker.MakeSound();  
        }
    }
}

