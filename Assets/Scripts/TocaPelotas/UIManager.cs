using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.UI;

namespace Scripts.TocaPelotas
{

    public class UIManager : MonoBehaviour
    {
        [SerializeField] TMP_Text tMP_ScoreText;
        [SerializeField] TMP_Text tMP_HighScoreText;
        [SerializeField] Button playbutton;
        [SerializeField] WorldManager worldmanager;


        private void Awake()
        {
            Assert.IsNotNull(playbutton, "ERROR: olvidaste el boton");
            Assert.IsNotNull(tMP_ScoreText, "ERROR: olvidaste el score");
            Assert.IsNotNull(tMP_HighScoreText, "ERROR: olvidaste el highscore");
        }
        internal  void UpdateScore(int score)
        {
            tMP_ScoreText.text = $"Score: {score.ToString()}";
        }

        internal void UpdateHighScore(int highscore)
        {
            tMP_HighScoreText.text = $"Highscore: {highscore.ToString()}";
        }
        public void StartGame()
        {
            //una vez le damos al boton debemos ocultarlo
            playbutton.gameObject.SetActive(false);
            worldmanager.StartGame();
        }

        internal void ShowPlayButton()
        {
            playbutton.gameObject.SetActive(true);
        }
    }
}
