using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Scripts.TocaPelotas
{
    // en cada requiremente podemos tener hasta 3 
    [RequireComponent(typeof(AudioSource), typeof(ParticleSystem))]
    public class CoinDestruction : MonoBehaviour
    {
        internal void Destroy (bool hasSound)
        {
            var audiosource = GetComponent<AudioSource>();
            var partycleSystem = GetComponent <ParticleSystem>();
            
            audiosource.mute = !hasSound;
            
            // duracion del clip: audioSource.clip.length
            // duracion de las particulasd: partycleSystem.main.duration + partycleSystem.main.startLifetime.constantMax
            float delay = Mathf.Max(audiosource.clip.length, 
                partycleSystem.main.duration + partycleSystem.main.startLifetime.constantMax);
            Destroy(gameObject,delay);
        }
    }

}