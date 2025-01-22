using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Scripts.TocaPelotas
{

    public class Spikes : MonoBehaviour
    {
        public event Action GameOverEvent;
        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.tag.Equals(Constantes.COIN_TAG))
                {
                GameOverEvent?.Invoke();
                }
        }
    }

}
