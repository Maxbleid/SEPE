using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using System;
using UnityEngine.Assertions;
using UnityEditor;
namespace Scripts.PONG
{
    //con el requirement podemos hacer que salte error si nos falta el elemento.
    //Nos evita poner el Assert y ademas te añade el componente pero vacio.
    [RequireComponent(typeof(AudioSource))]
    public class GoalArea : MonoBehaviour
    {
        [SerializeField] TMP_Text marcadorGoles;
        int goles;
        [SerializeField] float delay;
        AudioSource audioGol;
        private void Awake()
        {
            Assert.IsNotNull(marcadorGoles, "ERROR: olvidaste el texto");
            audioGol = GetComponent<AudioSource>();
            audioGol.playOnAwake = false; 
            goles = 0;
            marcadorGoles.text = goles.ToString();

            //para la posicion cogemos el tamaño y aspecto dela cámara y hacemos una regla de 3
            //ademas usamos el Math.Sign para coger el signo de la posicion que tiene el objeto
            float newPositionX = Camera.main.orthographicSize *
                                 Camera.main.aspect * Math.Sign(transform.position.x);
            transform.position = new Vector2(newPositionX,0); //damos el valor de X a la posicion inicial
        }
        private void OnTriggerEnter2D(Collider2D other)
        {
            //creamos un scripts de constants para de esa manera no tener que
            //usar cosas hardcodeadas.
            if (other.tag == Constants.BALL_TAG)
            {
                goles++;
                marcadorGoles.text = goles.ToString();
                audioGol.Play();
                StartCoroutine(ResetBall(other));
            }
        }

        IEnumerator ResetBall(Collider2D other)
        {
            yield return new WaitForSeconds(ResetDelay(delay));
            //otra forma
            //float delay= Mathf.Max(delay, audioGol.clip.lenght);
            other.GetComponent<Ball>().Reset();
        }

        float ResetDelay(float delay)
        {
            if (audioGol.clip.length < delay)
            {
                return delay;
            }
            else
            {
                return audioGol.clip.length;
            }
            
        }
    }

}
