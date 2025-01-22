using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;


namespace Scripts.TocaPelotas
{
    [RequireComponent(typeof(Collider2D))]
public class Coins : MonoBehaviour
    {
        [SerializeField, Min(1), Tooltip("Valor moneda")] int scorevalue=10;
        [SerializeField] ParticleSystem particulaDestroyPrefab;
        public event Action<Coins>  OnCoinDestroyedEvent; //el action event de los tipos Coins

        private void Awake()
        {
            Assert.IsNotNull(particulaDestroyPrefab, "ERROR: olvidaste las particulas");
        }
        internal int GetScoreValue()
        {
            return scorevalue;
        }

        private void OnMouseDown()
        {
            //Debug.Log(name);
            //con el Invoke se lanza el evento para que alguien lo escuche
            //uso el "?" para que una vez destruido no siga buscando alguien que lo escuche
            
            OnCoinDestroyedEvent?.Invoke(this);
            
        }
        internal void Destroy(bool hasSound)
        {
            var destructionGO = Instantiate(particulaDestroyPrefab,
                                                transform.position,
                                                transform.rotation);

            destructionGO.GetComponent<CoinDestruction>().Destroy(hasSound);
            //desactivamos la moneda
            gameObject.SetActive(false);
            //hago que la moneda sea hijo del CoinDestruction
            gameObject.transform.SetParent(destructionGO.transform);
            //Destroy(this.gameObject,0.5f); haciendo padre de la moneda a la instanciación del prefab de las particulas
            //entonces ya no haria falta ponerle un delay para que se destruya, ya que se destruirá junto con el prefab
        }

        internal void Dissapear()
        {

        }
    }
}
