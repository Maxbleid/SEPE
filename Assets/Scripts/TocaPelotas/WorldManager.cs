using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Assertions;


namespace Scripts.TocaPelotas
{
    [RequireComponent(typeof(AudioSource))]
    public class WorldManager : MonoBehaviour
    {
      

        [SerializeField] ScoreManager scoreManager;
        [Space(), Header("Configuracion")]
        [SerializeField] Coins [] coinPrefabs;
        [SerializeField, Min(1)] int maxNumberCoins = 5;
        [SerializeField, Range(0.5f, 2)] float minTimeBetweenCoins = 1f;
        [SerializeField, Range(0.5f, 2)] float maxTimeBetweenCoins = 2f;
        [SerializeField] Spikes spikes;

        [SerializeField] UIManager uiManager;
        List<Coins> arrayMonedas;

        bool isCoroutineActive;

        AudioSource audioSource;
        private void Awake() //se usa para validad datos e inicializar variables
        {
            Assert.IsNotNull(scoreManager, "ERROR: olvidaste el scoremanager");
            Assert.IsNotNull(uiManager, "ERROR: olvidaste el UIManager");
            Assert.IsTrue(coinPrefabs.Length>0, "ERROR: olvidaste los prefabs");
            Assert.IsTrue(minTimeBetweenCoins <= maxTimeBetweenCoins, "ERROR: tiempos no validos");
            arrayMonedas = new List<Coins>();   
            spikes.GameOverEvent += GameOverEventCallBack;
            audioSource = GetComponent<AudioSource>();
        }

        // creamos una corrutina ya que queremos que se ejecute algo con paradas de tiempo
        IEnumerator CrearMonedas()
        {
            isCoroutineActive = true;
            var waitingtime = Random.Range(minTimeBetweenCoins, maxTimeBetweenCoins);
            yield return new WaitForSeconds(waitingtime);
            if (arrayMonedas.Count < maxNumberCoins)
            {
                CrearMoneda();
                StartCoroutine(CrearMonedas());
            }
            else
            {
                isCoroutineActive = false;
            }
        }

        private void CrearMoneda()
        {
            //pongo los prefabs en pantala- creamos el gameobject
            int tipoMoneda = Random.Range(0, coinPrefabs.Length);
            var coin = Instantiate(coinPrefabs[tipoMoneda], transform);

            //añado la instanciación a la lista de monedas 
            arrayMonedas.Add(coin);

            //con esta linea escucha el evento del script Coins
            //se suscribe al evento OnCoinDestroyedEvent, para desuscribirse se usa "-="
            coin.OnCoinDestroyedEvent += OnCoinDestroyedCallBack;


            float horizontalMaxValue = Camera.main.orthographicSize * Camera.main.aspect*0.8f;
            float horizontalPosition = Random.Range(-horizontalMaxValue, horizontalMaxValue);
            coin.transform.position = new Vector3(horizontalPosition, Camera.main.orthographicSize*1.3f,0);
        }

        private void OnCoinDestroyedCallBack(Coins coin)
        {
            //me desuscribo para que solo coja el evento la primera vez.
            coin.OnCoinDestroyedEvent -= OnCoinDestroyedCallBack;
            //al desuscribirse queremos aun tner su scorevalue asi que asignamos
            // una variable a obtener el valor segun el metodo GetScoreValue
            int value = coin.GetScoreValue();
            scoreManager.AddScore(value); //mandamo el value al ScoreManager para que el lo use
            scoreManager.UpdateHighscore();
            arrayMonedas.Remove(coin);
            coin.Destroy(hasSound: true);
            maxNumberCoins++;
            if (!isCoroutineActive)
            {
                StartCoroutine(CrearMonedas());
            }
        }

        private void GameOverEventCallBack()
        {
            Debug.Log("GAME OVER");
            scoreManager.UpdateHighscore();
            // se puede usar StopCoroutine(), pero habria que pasarle la corrutina que queremos
            StopAllCoroutines();
            uiManager.ShowPlayButton();

            //cuando perdemos debemos destruir lo que quede en la lista y limpiar la lista
            foreach (var coin in arrayMonedas) 
            {
                //coin.GetComponent<ParticleSystem>().GetComponent<AudioSource>().mute = true;
                coin.Destroy(hasSound: false);
            }
            arrayMonedas.Clear();
            audioSource.Play();
        }

        internal void StartGame()
        {
            StartCoroutine(CrearMonedas());
            scoreManager.Reset();
        }
    }
}
