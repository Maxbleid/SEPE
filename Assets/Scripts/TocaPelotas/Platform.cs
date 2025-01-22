using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Scripts.TocaPelotas
{

public class Platform : MonoBehaviour
{
        AudioSource bouncing;
        private void Awake()
        {
            bouncing = GetComponent<AudioSource>();
        }
        private void OnCollisionEnter2D(Collision2D other)
        {
            if (other.gameObject.tag.Equals(Constantes.COIN_TAG))
            {
                bouncing.Play();
            }
        }
    }

}