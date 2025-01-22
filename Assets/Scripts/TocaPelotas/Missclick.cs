using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Scripts.TocaPelotas
{

    [RequireComponent(typeof(AudioSource))]
public class Missclick : MonoBehaviour
{
        AudioSource audioSource;

        private void Awake()
        {
            audioSource = GetComponent<AudioSource>();
        }

        private void OnMouseDown()
        {
            audioSource.Play();
        }

    }
}
