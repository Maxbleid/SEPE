using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

namespace Scripts.TocaPelotas
{

    public class ScoreManager : MonoBehaviour
    {
        [SerializeField] UIManager  uIManager;
        int score;
        private int highscore;

        private void Awake()
        {
            Assert.IsNotNull(uIManager, "ERROR: olvidaste el uimanager");
          
            //no se debe guardar informacion sensible en el PlayerPrefs (correo, nombre, dni....)
            //PlayerPrefs.SetInt("Score", score);
            //cogemos el valor de Playerprefs que asignamos a una clave, si no tiene valro,entonces es 0 por defecto
            highscore = PlayerPrefs.GetInt(Constantes.HIGHSCORE_KEY, 0);
            uIManager.UpdateHighScore(highscore);
            Reset();
        }

        internal void AddScore(int value)
        {
            score += value;
            uIManager.UpdateScore(score);
        }

        //internal sirve para que todo el que este dentro de tu namespace pueda verlo (como si fuera public)
        internal void UpdateHighscore()
        {
           if (score > highscore)
            {
                highscore = score;
                uIManager.UpdateHighScore(highscore);
                PlayerPrefs.SetInt(Constantes.HIGHSCORE_KEY, score);
            }
            else
            {
                uIManager.UpdateHighScore(highscore);
                PlayerPrefs.SetInt(Constantes.HIGHSCORE_KEY, highscore);
            }
        }

        internal void Reset()
        {
            score = 0;
            uIManager.UpdateScore(score);
        }
    }

}